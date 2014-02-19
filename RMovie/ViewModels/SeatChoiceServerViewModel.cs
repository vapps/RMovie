using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RMovie.PCL.Models;
using RMovie.PCL.ViewModels;

namespace RMovie.ViewModels
{
    public class SeatChoiceServerViewModel : SeatChoiceViewModel
    {
        private string[] Line0 = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        private string[] Line1 = { "1", "2", "3", "4", "5", "6", "", "11", "12", "13", "14", "15", "16", "17", "18", "", "21", "22", "23", "24", "25", "26" };
        private string[] Line2 = { "", "", "3", "4", "5", "6", "", "11", "12", "13", "14", "15", "16", "17", "18", "", "21", "22", "23", "24", "", "" };
        private string[] LineNames = { "A1", "B1", "C1", "D1", "E1", "F1", "G1", "H1", "I1", "J1", "K1", "L1", "M1", "N2", "", "O1", "P1", "Q2" };

        public void Init()
        {
            if (LineCollection.Count > 0) return;

            foreach (var line in LineNames)
            {
                var lineName = string.Empty;
                var lineType = string.Empty;
                if (line.Length > 0)
                {
                    lineName = line.Substring(0, 1);
                    lineType = line.Substring(1, 1);
                }
                var newLine = new LineModel
                {
                    LineName = lineName
                };

                string[] seats = { };
                switch (lineType)
                {
                    case "1":
                        seats = Line1;
                        break;
                    case "2":
                        seats = Line2;
                        break;
                    default:
                        seats = Line0;
                        break;
                }

                foreach (var s in seats)
                {
                    var seat = new SeatModel();
                    seat.LineName = newLine.LineName;
                    switch (s)
                    {
                        case "":
                            seat.SeatNum = "";
                            seat.SeatState = SeatStateEnum.Nothing;
                            break;
                        default:
                            seat.SeatNum = s;
                            seat.SeatState = SeatStateEnum.ChoiceNobodyNormal;
                            break;
                    }
                    newLine.SeatCollection.Add(seat);
                }

                LineCollection.Add(newLine);
            }
            if (1 == 1)
            {
            }
        }

    }
}