using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace TicTacToe.Core
{
    public class Judge
    {
        public enum JudgeResult
        {
            Unfinished,
            XWins,
            OWins,
            Draw
        }

        public Judge(Line[] lines)
        {
            foreach (var line in lines)
            {
                if (line.Members.All(member => member.Content == "O"))
                {
                    Result = JudgeResult.OWins;
                    ReasonLine = line;
                    return;
                }
                if (line.Members.All(member => member.Content == "X"))
                {
                    Result = JudgeResult.XWins;
                    ReasonLine = line;
                    return;
                }
            }
            if (lines[0].Members.All(member => member.Content != null) &&
                lines[1].Members.All(member => member.Content != null) &&
                lines[2].Members.All(member => member.Content != null))
            {
                Result = JudgeResult.Draw;
                ReasonLine = null;
            }
            else
            {
                Result = JudgeResult.Unfinished;
                ReasonLine = null;
            }
        }

        public JudgeResult Result { get; private set; }
        public Line ReasonLine { get; private set; }
    }

    public class AIResult
    {
        public AIResult(string labelName, string content)
        {
            LabelName = labelName;
            Content = content;
        }

        public string LabelName { get; private set; }
        public string Content { get; private set; }
    }

    public class Element
    {
        public Element(int row, int column, string content)
        {
            Row = row;
            Column = column;
            Content = content;
        }

        public Element()
        {
            // Reserved For XmlSerializer
        }

        [XmlElement("Row")]
        public int Row { get; set; }

        [XmlElement("Column")]
        public int Column { get; set; }

        [XmlElement("Content")]
        public string Content { get; set; }
    }

    public class ElementComparer : IEqualityComparer<Element>
    {
        public bool Equals(Element x, Element y)
        {
            return (x.Column == y.Column) && (x.Row == y.Row);
        }

        public int GetHashCode(Element obj)
        {
            var hash = obj.Row ^ obj.Column;
            return hash.GetHashCode();
        }
    }

    public class Line
    {
        public enum LineStatus
        {
            Win,
            Block,
            AIOnly,
            PlayerOnly,
            Useless
        }

        public Line(Element[] members, string aiContent)
        {
            Members = members;
            BestHand = null;
            var aiCount = 0;
            var playerCount = 0;
            foreach (var member in members)
            {
                if (member.Content == aiContent) aiCount++;
                else if (member.Content == null) BestHand = member;
                else playerCount++;
            }
            if (aiCount == 2 && playerCount == 0)
            {
                Status = LineStatus.Win;
            }
            else if (aiCount == 0 && playerCount == 2)
            {
                Status = LineStatus.Block;
            }
            else if (aiCount == 1 && playerCount == 0)
            {
                Status = LineStatus.AIOnly;
            }
            else if (aiCount == 0 && playerCount == 1)
            {
                Status = LineStatus.PlayerOnly;
            }
            else
            {
                Status = LineStatus.Useless;
            }
        }

        public Element[] Members { get; private set; }
        public LineStatus Status { get; private set; }
        public Element BestHand { get; private set; }
    }

    [Serializable]
    public class Record
    {
        public Record(GameCore.GameMode mode, string winner, List<Element> steps)
        {
            Time = DateTime.Now;
            Mode = mode;
            Winner = winner;
            Steps = steps;
        }

        public Record()
        {
            // Reserved For XmlSerializer
        }

        [XmlElement("Time")]
        public DateTime Time { get; set; }

        [XmlElement("Mode")]
        public GameCore.GameMode Mode { get; set; }

        [XmlElement("Winner")]
        public string Winner { get; set; }

        [XmlElement("Steps")]
        public List<Element> Steps { get; set; }
    }
}