using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe.Core
{
    public class GameCore
    {
        public enum GameMode
        {
            AI,
            Manual
        }

        private string[,] _boardElements;
        private ElementComparer _comparer;
        private Element[] _corners;
        private Element[] _sides;

        public GameCore(GameMode mode)
        {
            Mode = mode;
            GameFinished = false;
            _boardElements = new string[3, 3];
            Lines = new Line[8];
            HistoryHands = new List<Element>(9);
            _comparer = new ElementComparer();
            NextHandContent = "X";
        }

        public List<Element> HistoryHands { get; private set; }
        public GameMode Mode { get; private set; }
        public bool GameFinished { get; set; }
        public string NextHandContent { get; private set; }
        public Line[] Lines { get; private set; }

        public void CurrentHand(int row, int column)
        {
            _boardElements[row, column] = NextHandContent;
            HistoryHands.Add(new Element(row, column, NextHandContent));
            NextHand();
            AnalyzeBoard();
        }

        public AIResult[] BackHand()
        {
            switch (HistoryHands.Count)
            {
                case 0:
                    return null;
                case 1:
                    var onlyHand = HistoryHands[0];
                    _boardElements[onlyHand.Row, onlyHand.Column] = null;
                    HistoryHands.RemoveAt(0);
                    AnalyzeBoard();
                    return new[] {ConstructNullResult(onlyHand)};
                default:
                    var lastHand = HistoryHands[HistoryHands.Count - 1];
                    var previousHand = HistoryHands[HistoryHands.Count - 2];
                    _boardElements[lastHand.Row, lastHand.Column] = null;
                    _boardElements[previousHand.Row, previousHand.Column] = null;
                    HistoryHands.Remove(lastHand);
                    HistoryHands.Remove(previousHand);
                    AnalyzeBoard();
                    return new[] {ConstructNullResult(lastHand), ConstructNullResult(previousHand)};
            }
        }

        public void NextHand()
        {
            switch (NextHandContent)
            {
                case "O":
                    NextHandContent = "X";
                    break;
                case "X":
                    NextHandContent = "O";
                    break;
            }
        }

        public Judge JudgeGame()
        {
            var judge = new Judge(Lines);
            if (judge.Result != Judge.JudgeResult.Unfinished) GameFinished = true;
            return judge;
        }

        public AIResult AICalc()
        {
            var winResult = CheckWin();
            if (winResult != null) return ConstructAIResult(winResult);
            var blockResult = CheckBlock();
            if (blockResult != null) return ConstructAIResult(blockResult);
            var forkResult = CheckFork();
            if (forkResult != null) return ConstructAIResult(forkResult);
            var blockForkResult = CheckBlockFork();
            if (blockForkResult != null) return ConstructAIResult(blockForkResult);
            var centerResult = CheckCenter();
            if (centerResult != null) return ConstructAIResult(centerResult);
            var oppositeCorner = CheckOppositeCorner();
            if (oppositeCorner != null) return ConstructAIResult(oppositeCorner);
            var randomCorner = RandomCorner();
            if (randomCorner != null) return ConstructAIResult(randomCorner);
            var randomSide = RandomSide();
            if (randomSide != null) return ConstructAIResult(randomSide);
            return null;
        }

        public void AnalyzeBoard()
        {
            var lineMembers = new Element[8][];
            for (var row = 0; row < 3; row++)
            {
                lineMembers[row] = new[]
                {
                    new Element(row, 0, _boardElements[row, 0]),
                    new Element(row, 1, _boardElements[row, 1]),
                    new Element(row, 2, _boardElements[row, 2])
                };
            }
            for (var column = 0; column < 3; column++)
            {
                lineMembers[column + 3] = new[]
                {
                    new Element(0, column, _boardElements[0, column]),
                    new Element(1, column, _boardElements[1, column]),
                    new Element(2, column, _boardElements[2, column])
                };
            }
            lineMembers[6] = new[]
            {
                new Element(0, 0, _boardElements[0, 0]),
                new Element(1, 1, _boardElements[1, 1]),
                new Element(2, 2, _boardElements[2, 2])
            };
            lineMembers[7] = new[]
            {
                new Element(0, 2, _boardElements[0, 2]),
                new Element(1, 1, _boardElements[1, 1]),
                new Element(2, 0, _boardElements[2, 0])
            };
            for (var index = 0; index < 8; index++)
            {
                Lines[index] = new Line(lineMembers[index], NextHandContent);
            }
            _corners = new[]
            {
                new Element(0, 0, _boardElements[0, 0]),
                new Element(0, 2, _boardElements[0, 2]),
                new Element(2, 0, _boardElements[2, 0]),
                new Element(2, 2, _boardElements[2, 2])
            };
            _sides = new[]
            {
                new Element(0, 1, _boardElements[0, 1]),
                new Element(1, 0, _boardElements[1, 0]),
                new Element(1, 2, _boardElements[1, 2]),
                new Element(2, 1, _boardElements[2, 1])
            };
        }

        private Element CheckWin()
        {
            var winLine = Lines.FirstOrDefault(line => line.Status == Line.LineStatus.Win);
            return winLine != null ? winLine.BestHand : null;
        }

        private Element CheckBlock()
        {
            var blockLine = Lines.FirstOrDefault(line => line.Status == Line.LineStatus.Block);
            return blockLine != null ? blockLine.BestHand : null;
        }

        private Element CheckFork()
        {
            var aiOnlyLines = Lines.Where(line => line.Status == Line.LineStatus.AIOnly).ToArray();
            for (var index1 = 0; index1 < aiOnlyLines.Length; index1++)
            {
                for (var index2 = index1 + 1; index2 < aiOnlyLines.Length; index2++)
                {
                    var aiNulls1 = aiOnlyLines[index1].Members.Where(member1 => member1.Content == null);
                    var aiNulls2 = aiOnlyLines[index2].Members.Where(member2 => member2.Content == null);
                    var searchCommon = aiNulls1.Intersect(aiNulls2, _comparer).FirstOrDefault();
                    if (searchCommon != null) return searchCommon;
                }
            }
            return null;
        }

        private Element CheckBlockFork()
        {
            var playerOnlyLines = Lines.Where(line => line.Status == Line.LineStatus.PlayerOnly).ToArray();
            var elementsToAvoid = new List<Element>();
            for (var index1 = 0; index1 < playerOnlyLines.Length; index1++)
            {
                for (var index2 = index1 + 1; index2 < playerOnlyLines.Length; index2++)
                {
                    var playerNulls1 = playerOnlyLines[index1].Members.Where(member1 => member1.Content == null);
                    var playerNulls2 = playerOnlyLines[index2].Members.Where(member2 => member2.Content == null);
                    var searchCommon = playerNulls1.Intersect(playerNulls2, _comparer).FirstOrDefault();
                    if (searchCommon != null) elementsToAvoid.Add(searchCommon);
                }
            }
            switch (elementsToAvoid.Count)
            {
                case 0:
                    return null;
                case 1:
                    return elementsToAvoid.First();
                default:
                    var rand = new Random();
                    var aiLines = Lines.Where(
                        line => line.Status == Line.LineStatus.AIOnly &&
                                !line.Members.Any(member => elementsToAvoid.Contains(member, _comparer))).ToArray();
                    return aiLines.Length > 0
                        ? aiLines[rand.Next(aiLines.Length)].Members.FirstOrDefault(member => member.Content == null)
                        : null;
            }
        }

        private Element CheckOppositeCorner()
        {
            var playerCorners = _corners.Where(corner => corner.Content != NextHandContent && corner.Content != null);
            return (from playerCorner in playerCorners
                select GetOppositeCorner(playerCorner)
                into oppositeCorner
                where oppositeCorner.Content == null
                select oppositeCorner).FirstOrDefault();
        }

        private Element CheckCenter()
        {
            return _boardElements[1, 1] == null ? new Element(1, 1, _boardElements[1, 1]) : null;
        }

        private Element GetOppositeCorner(Element corner)
        {
            if (corner.Row == 0 && corner.Column == 0) return new Element(2, 2, _boardElements[2, 2]);
            if (corner.Row == 0 && corner.Column == 2) return new Element(2, 0, _boardElements[2, 0]);
            if (corner.Row == 2 && corner.Column == 0) return new Element(0, 2, _boardElements[0, 2]);
            if (corner.Row == 2 && corner.Column == 2) return new Element(0, 0, _boardElements[0, 0]);
            return null;
        }

        private Element RandomCorner()
        {
            var emptyCorners = _corners.Where(corner => corner.Content == null).ToArray();
            if (emptyCorners.Length == 0) return null;
            var rand = new Random();
            return emptyCorners[rand.Next(emptyCorners.Length)];
        }

        private Element RandomSide()
        {
            var emptySides = _sides.Where(corner => corner.Content == null).ToArray();
            if (emptySides.Length == 0) return null;
            var rand = new Random();
            return emptySides[rand.Next(emptySides.Length)];
        }

        private AIResult ConstructAIResult(Element element)
        {
            var content = NextHandContent;
            CurrentHand(element.Row, element.Column);
            return new AIResult("Board" + element.Row + "_" + element.Column, content);
        }

        private AIResult ConstructNullResult(Element element)
        {
            return new AIResult("Board" + element.Row + "_" + element.Column, "");
        }
    }
}