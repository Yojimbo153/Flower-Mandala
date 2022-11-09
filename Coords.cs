using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections;
using System.Xml.Linq;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
//using Flower1.Views;

//using Flower1.Models;

namespace FlowerApp2.Views
{
   
        [XamlCompilation(XamlCompilationOptions.Compile)]
        public partial class Coords : INotifyPropertyChanged
        {

            public Coords()
            {
                //InitializeComponent();


                name = "Enter new Design Name";
                color1 = "#ffff0000";
                color2 = "#ffff0000";                        // width = "2000";                                                                             
                color3 = "#ffff0000";
                color4 = "#FFFFFFFF";
                cStroke1 = "10";
                cStroke2 = "10";
                cStroke3 = "10";
                preciseDegrees = "3.0";
                degrees = "3.0";
                radii = "10.0";
                radiiLimit = "360.0";
                angle = "10";
                angleLimit = "1080";
                fullScale = "0.5";
                coordsString = "None                                    #ffff0000      #ffff0000      #ffff0000      #ffffffff      3.0            3.0            10.0           360.0          10             1080           0.5     3      3      3      0  true ";
                key = 0;
                isVisible = true;

            }

            public Coords(KeyChain K)
            {
                name = "Enter New Design Name";
                color1 = "#ffff0000";
                color2 = "#ffff0000";                        // width = "2000";                                                                             
                color3 = "#ffff0000";
                color4 = "#FFFFFFFF";
                cStroke1 = "10";
                cStroke2 = "10";
                cStroke3 = "10";
                preciseDegrees = "3.0";
                degrees = "3.0";
                radii = "10.0";
                radiiLimit = "360.0";
                angle = "10";
                angleLimit = "1080";
                fullScale = "0.5";
                coordsString = "None                                    #ffff0000      #ffff0000      #ffff0000      #ffffffff      3.0            3.0            10.0           360.0          10             1080           0.5     3      3      3      0  true ";
                key = K.getNewKey();
                isVisible = true;

            }

            public Coords(string coord)
            {
                coordsString = coord;
                makeUniformForLoading();
                makeUniformForSaving();


            }

            public Coords(Coords C)
            {
                coordsString = C.CoordsString;
                makeUniformForLoading();
                makeUniformForSaving();
            }

            



            public event PropertyChangedEventHandler PropertyChanged;  // = delegate { };

            private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

            private string Name;
            public string name
            {
                get { return Name; }
                set
                {
                    Name = value;
                    NotifyPropertyChanged("name");
                }
            }

            private string Color1;
            public string color1
            {
                get { return Color1; }
                set
                {
                    Color1 = value;
                    NotifyPropertyChanged("color1");
                }
            }


            private string Color2;
            public string color2
            {
                get { return Color2; }
                set
                {
                    Color2 = value;
                    NotifyPropertyChanged("color2");
                }
            }


            private string Color3;
            public string color3
            {
                get { return Color3; }
                set
                {
                    Color3 = value;
                    NotifyPropertyChanged("color3");
                }
            }


            private string Color4;
            public string color4
            {
                get { return Color4; }
                set
                {
                    Color4 = value;
                    NotifyPropertyChanged("color4");
                }
            }

            private bool IsVisible;
            public bool isVisible
            {
                get { return IsVisible; }
                set
                {
                    IsVisible = value;
                    NotifyPropertyChanged("isVisible");
                }
            }


            private int Key;
            public int key
            {
                get { return Key; }
                set
                {
                    Key = value;
                    NotifyPropertyChanged("keyChain");
                }
            }



            private string PreciseDegrees;
            public string preciseDegrees
            {
                get { return PreciseDegrees; }
                set
                {
                    PreciseDegrees = value;
                    NotifyPropertyChanged("preciseDegrees");
                }
            }


            private string Degrees;
            public string degrees
            {
                get { return Degrees; }
                set
                {
                    Degrees = value;
                    NotifyPropertyChanged("degrees");
                }
            }


            private string Radii;
            public string radii
            {
                get { return Radii; }
                set
                {
                    Radii = value;
                    NotifyPropertyChanged("radii");
                }
            }


            private string RadiiLimit;
            public string radiiLimit
            {
                get { return RadiiLimit; }
                set
                {
                    RadiiLimit = value;
                    NotifyPropertyChanged("radiiLimit");
                }
            }


            private string Angle;
            public string angle
            {
                get { return Angle; }
                set
                {
                    Angle = value;
                    NotifyPropertyChanged("angle");
                }
            }


            private string AngleLimit;
            public string angleLimit
            {
                get { return AngleLimit; }
                set
                {
                    AngleLimit = value;
                    NotifyPropertyChanged("angleLimit");
                }
            }


            private string FullScale;
            public string fullScale
            {
                get { return FullScale; }
                set
                {
                    FullScale = value;
                    NotifyPropertyChanged("fullScale");
                }
            }



            private string CStroke1;
            public string cStroke1
            {
                get { return CStroke1; }
                set
                {
                    CStroke1 = value;
                    NotifyPropertyChanged("cStroke1");
                }
            }



            private string CStroke2;
            public string cStroke2
            {
                get { return CStroke2; }
                set
                {
                    CStroke2 = value;
                    NotifyPropertyChanged("cStroke2");
                }
            }


            private string CStroke3;
            public string cStroke3
            {
                get { return CStroke3; }
                set
                {
                    CStroke3 = value;
                    NotifyPropertyChanged("cStroke3");
                }
            }

            private string CoordsString;
            public string coordsString
            {
                get { return CoordsString; }
                set
                {
                    CoordsString = value;
                    NotifyPropertyChanged("coordsString");
                }
            }

            public override string ToString()
            {
               makeUniformForSaving();
                return coordsString.ToString();
            }

            public void makeUniformForLoading()
            {
                string UnTrimmedString;

                if (coordsString != null)
                {

                    UnTrimmedString = coordsString.Substring(0, 40);
                    name = UnTrimmedString.Trim();
                    UnTrimmedString = coordsString.Substring(40, 15);
                    color1 = UnTrimmedString.Trim();
                    UnTrimmedString = coordsString.Substring(55, 15);
                    color2 = UnTrimmedString.Trim();
                    UnTrimmedString = coordsString.Substring(70, 15);
                    color3 = UnTrimmedString.Trim();
                    UnTrimmedString = coordsString.Substring(85, 15);
                    color4 = UnTrimmedString.Trim();
                    UnTrimmedString = coordsString.Substring(100, 15);
                    preciseDegrees = UnTrimmedString.Trim();
                    UnTrimmedString = coordsString.Substring(115, 15);
                    degrees = UnTrimmedString.Trim();
                    UnTrimmedString = coordsString.Substring(130, 15);
                    radii = UnTrimmedString.Trim();
                    UnTrimmedString = coordsString.Substring(145, 15);
                    radiiLimit = UnTrimmedString.Trim();
                    UnTrimmedString = coordsString.Substring(160, 15);
                    angle = UnTrimmedString.Trim();
                    UnTrimmedString = coordsString.Substring(175, 15);
                    angleLimit = UnTrimmedString.Trim();
                    UnTrimmedString = coordsString.Substring(190, 7);
                    fullScale = UnTrimmedString.Trim();
                    UnTrimmedString = coordsString.Substring(197, 7);
                    cStroke1 = UnTrimmedString.Trim();
                    UnTrimmedString = coordsString.Substring(204, 7);
                    cStroke2 = UnTrimmedString.Trim();
                    UnTrimmedString = coordsString.Substring(211, 7);
                    cStroke3 = UnTrimmedString.Trim();
                    UnTrimmedString = coordsString.Substring(218, 3);
                    key = int.Parse(UnTrimmedString.Trim());
                    UnTrimmedString = coordsString.Substring(221, 5);
                    isVisible = bool.Parse(UnTrimmedString.Trim());
                }
            }



            public void makeUniformForSaving()
            {
                coordsString = null;

                coordsString += name.PadRight(40);
                coordsString += color1.PadRight(15);
                coordsString += color2.PadRight(15);
                coordsString += color3.PadRight(15);
                coordsString += color4.PadRight(15);
                coordsString += preciseDegrees.PadRight(15);
                coordsString += degrees.PadRight(15);
                coordsString += radii.PadRight(15);
                coordsString += radiiLimit.PadRight(15);
                coordsString += angle.PadRight(15);
                coordsString += angleLimit.PadRight(15);
                coordsString += fullScale.PadRight(7);
                coordsString += cStroke1.ToString().PadRight(7);
                coordsString += cStroke2.ToString().PadRight(7);
                coordsString += cStroke3.ToString().PadRight(7);
                coordsString += key.ToString().PadRight(3);
                coordsString += isVisible.ToString().PadRight(5);
            }

        }



        public partial class TempoCoords : Coords
        {
            public string tempo { get; set; }
            public TempoCoords()
            {
                tempo = "0";
            }

            public void makeUniformForLoading()
            {
                string UnTrimmedString;
                base.makeUniformForLoading();
                UnTrimmedString = coordsString.Substring(226, 5);
                tempo = UnTrimmedString.Trim();
            }

            public void makeUniformForSaving()
            {
                base.makeUniformForSaving();
                coordsString += tempo.ToString().PadRight(5);
            }
        }
}

