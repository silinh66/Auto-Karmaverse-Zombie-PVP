using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using KAutoHelper;
using Color = System.Drawing.Color;

namespace adb_auto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region data
        Bitmap BOMB_BMP;
        Bitmap BIG_BOMB_BMP;
        Bitmap WIN_BMP;
        Bitmap LEVEL_UP_BMP;
        Bitmap STAGE1_BMP;
        Bitmap STAGE2_BMP;
        Bitmap UPGRADE_BUILDING_BMP;
        Bitmap PLUS_BMP;
        Bitmap PYRO_BMP;
        Bitmap BUILDING_RIGHT_YELLOW_CAR_BMP;
        Bitmap WIN_PVP_BMP;
        Bitmap NEXT_BMP;
        #endregion

        int delayShort = 50, delayLong = 500;
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            BOMB_BMP = (Bitmap)Bitmap.FromFile("Data/bomb.png");
            BIG_BOMB_BMP = (Bitmap)Bitmap.FromFile("Data/big_bomb.png");
            WIN_BMP = (Bitmap)Bitmap.FromFile("Data/win.png");
            LEVEL_UP_BMP = (Bitmap)Bitmap.FromFile("Data/level_up.png");
            STAGE1_BMP = (Bitmap)Bitmap.FromFile("Data/stage1.png");
            STAGE2_BMP = (Bitmap)Bitmap.FromFile("Data/stage2.png");
            UPGRADE_BUILDING_BMP = (Bitmap)Bitmap.FromFile("Data/upgrade_building.png");
            PLUS_BMP = (Bitmap)Bitmap.FromFile("Data/plus.png");
            PYRO_BMP = (Bitmap)Bitmap.FromFile("Data/pyro.png");
            BUILDING_RIGHT_YELLOW_CAR_BMP = (Bitmap)Bitmap.FromFile("Data/buildingRightYellowCar.png");
            WIN_PVP_BMP = (Bitmap)Bitmap.FromFile("Data/win_pvp.png");
            NEXT_BMP = (Bitmap)Bitmap.FromFile("Data/next.png");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Task t = new Task(() =>
            {
                isStop = false;
                Auto();
            });
            t.Start();
        }

        bool isStop = false;

        string[,] IntArray = new string[7, 5];

        bool ColorsAreClose(Color a, Color z, int threshold = 20)
        {
            int r = (int)a.R - z.R,
                g = (int)a.G - z.G,
                b = (int)a.B - z.B;
            return (r * r + g * g + b * b) <= threshold * threshold;
        }

        void scanBoard(string deviceID)
        {
            var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
            //var bluePoints = KAutoHelper.ImageScanOpenCV.FindOutPoints(screen, BLUE_BMP);
            //var redPoints = KAutoHelper.ImageScanOpenCV.FindOutPoints(screen, RED_BMP);
            //var yellowPoints = KAutoHelper.ImageScanOpenCV.FindOutPoints(screen, YELLOW_BMP);
            //var greenPoints = KAutoHelper.ImageScanOpenCV.FindOutPoints(screen, GREEN_BMP);
            //var purplePoints = KAutoHelper.ImageScanOpenCV.FindOutPoints(screen, PURPLE_BMP);
            //var bomBluePoints = KAutoHelper.ImageScanOpenCV.FindOutPoints(screen, BOMB_BLUE_BMP);
            //var bomYellowPoints = KAutoHelper.ImageScanOpenCV.FindOutPoints(screen, BOMB_YELLOW_BMP);
            //var bigBombYellowPoints = KAutoHelper.ImageScanOpenCV.FindOutPoints(screen, BIG_BOMB_YELLOW_BMP);
            //yellow 255 255 239 198 
            //blue 255 62 218 247
            //green 255 147 232 71
            //red 255 249 79 79
            //purple 255 243 134 243
            Color yellow = Color.FromArgb(255, 239, 198);
            Color yellow2 = Color.FromArgb(248, 205, 61);
            Color blue = Color.FromArgb(62, 199, 249);
            Color blue2 = Color.FromArgb(72, 166, 197);
            Color blue3 = Color.FromArgb(56, 213, 246);
            Color blue4 = Color.FromArgb(89, 140, 171);
            Color blue5 = Color.FromArgb(44, 200, 233);
            Color blue6 = Color.FromArgb(50, 207, 240);
            Color blue7 = Color.FromArgb(52, 150, 193);
            Color blue8 = Color.FromArgb(110, 118, 126);
            Color green = Color.FromArgb(147, 232, 71);
            Color green2 = Color.FromArgb(147, 232, 71);
            Color red = Color.FromArgb(249, 79, 79);
            Color red2 = Color.FromArgb(223, 151, 151);
            Color red3 = Color.FromArgb(247, 210, 210);
            Color red4 = Color.FromArgb(230, 84, 84);
            Color red5 = Color.FromArgb(239, 77, 78);
            Color red6 = Color.FromArgb(225, 176, 176);
            Color purple = Color.FromArgb(243, 134, 243);
            Color purple2 = Color.FromArgb(243, 134, 243);
            //Color pixcelColor = screen.GetPixel(1 * 100 + 60, 3 * 100 + 510);
            //System.Diagnostics.Debug.WriteLine(pixcelColor);
            //System.Diagnostics.Debug.WriteLine(ColorsAreClose(pixcelColor, red6));




            //(60, 510); (160, 510); (260, 510); (360; 510); (460; 510); (560; 510); (660; 510); 
            //(60, 610); (160, 610); (260, 610); (360; 610); (460; 610); (560; 610); (660; 610); 
            //(60, 710); (160, 710); (260, 710); (360; 710); (460; 710); (560; 710); (660; 710); 
            //(60, 810); (160, 810); (260, 810); (360; 810); (460; 810); (560; 810); (660; 810); 
            //(60, 910); (160, 910); (260, 910); (360; 910); (460; 910); (560; 910); (660; 910); 

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Color pixcelColor = screen.GetPixel(i * 100 + 60, j * 100 + 510);
                    if (ColorsAreClose(pixcelColor, yellow) || ColorsAreClose(pixcelColor, yellow2))
                    {
                        IntArray[i, j] = "yellow";
                        continue;
                    }
                    if (ColorsAreClose(pixcelColor, blue) || ColorsAreClose(pixcelColor, blue2) || ColorsAreClose(pixcelColor, blue3) || ColorsAreClose(pixcelColor, blue4) || ColorsAreClose(pixcelColor, blue5) || ColorsAreClose(pixcelColor, blue6) || ColorsAreClose(pixcelColor, blue7) || ColorsAreClose(pixcelColor, blue8))
                    {
                        IntArray[i, j] = "blue";
                        continue;
                    }
                    if (ColorsAreClose(pixcelColor, green) || ColorsAreClose(pixcelColor, green2))
                    {
                        IntArray[i, j] = "green";
                        continue;
                    }
                    if (ColorsAreClose(pixcelColor, red) || ColorsAreClose(pixcelColor, red2) || ColorsAreClose(pixcelColor, red3) || ColorsAreClose(pixcelColor, red4) || ColorsAreClose(pixcelColor, red5) || ColorsAreClose(pixcelColor, red6))
                    {
                        IntArray[i, j] = "red";
                        continue;
                    }
                    if (ColorsAreClose(pixcelColor, purple) || ColorsAreClose(pixcelColor, purple2))
                    {
                        IntArray[i, j] = "purple";
                        continue;
                    }

                    //System.Diagnostics.Debug.WriteLine(pixcelColor);
                    //System.Diagnostics.Debug.WriteLine(ColorsAreClose(pixcelColor, blue));
                }
            }


            //if (bluePoints != null)
            //{
            //    for (int i = 0; i < bluePoints.Count; i++)
            //    {
            //        int xCoor = (int)Math.Floor((decimal)(bluePoints[i].X / 100));
            //        int yCoor = (int)Math.Floor((decimal)((bluePoints[i].Y - 500) / 100));
            //        //if (bluePoints[i].X % 100 > 35 && bluePoints[i].X % 100 < 50 && bluePoints[i].Y % 100 <35 && bluePoints[i].Y % 100 > 20)
            //        //{
            //        IntArray[xCoor, yCoor] = "blue";
            //        //}
            //        //else
            //        //{

            //        //    IntArray[xCoor, yCoor] = "null";
            //        //}


            //    }

            //}
            //if (bomBluePoints != null)
            //{
            //    for (int i = 0; i < bomBluePoints.Count; i++)
            //    {
            //        //System.Diagnostics.Debug.WriteLine(bluePoints[i]);
            //        int xCoor = (int)Math.Floor((decimal)(bomBluePoints[i].X / 100));
            //        int yCoor = (int)Math.Floor((decimal)((bomBluePoints[i].Y - 500) / 100));

            //        IntArray[xCoor, yCoor] = "blue";
            //    }

            //}
            //if (bomYellowPoints != null)
            //{
            //    for (int i = 0; i < bomYellowPoints.Count; i++)
            //    {
            //        //System.Diagnostics.Debug.WriteLine(bluePoints[i]);
            //        int xCoor = (int)Math.Floor((decimal)(bomYellowPoints[i].X / 100));
            //        int yCoor = (int)Math.Floor((decimal)((bomYellowPoints[i].Y - 500) / 100));

            //        IntArray[xCoor, yCoor] = "yellow";
            //    }

            //}
            //if (bigBombYellowPoints != null)
            //{
            //    for (int i = 0; i < bigBombYellowPoints.Count; i++)
            //    {
            //        //System.Diagnostics.Debug.WriteLine(bluePoints[i]);
            //        int xCoor = (int)Math.Floor((decimal)(bigBombYellowPoints[i].X / 100));
            //        int yCoor = (int)Math.Floor((decimal)((bigBombYellowPoints[i].Y - 500) / 100));

            //        IntArray[xCoor, yCoor] = "yellow";
            //    }

            //}
            //if (redPoints != null)
            //{
            //    for (int i = 0; i < redPoints.Count; i++)
            //    {
            //        //System.Diagnostics.Debug.WriteLine(redPoints[i]);
            //        int xCoor = (int)Math.Floor((decimal)(redPoints[i].X / 100));
            //        int yCoor = (int)Math.Floor((decimal)((redPoints[i].Y - 500) / 100));
            //        //if (redPoints[i].X % 100 > 35 && redPoints[i].X % 100 < 50 && redPoints[i].Y % 100 < 35 && redPoints[i].Y % 100 > 20)
            //        //{
            //        IntArray[xCoor, yCoor] = "red";
            //        //}
            //        //else
            //        //{
            //        //    IntArray[xCoor, yCoor] = "null";
            //        //}

            //    }

            //}
            //if (yellowPoints != null)
            //{
            //    for (int i = 0; i < yellowPoints.Count; i++)
            //    {
            //        //System.Diagnostics.Debug.WriteLine(yellowPoints[i]);
            //        int xCoor = (int)Math.Floor((decimal)(yellowPoints[i].X / 100));
            //        int yCoor = (int)Math.Floor((decimal)((yellowPoints[i].Y - 500) / 100));
            //        //if (yellowPoints[i].X % 100 > 45 && yellowPoints[i].X % 100 < 60 && yellowPoints[i].Y % 100 < 50 && yellowPoints[i].Y % 100 > 30)
            //        //{
            //        IntArray[xCoor, yCoor] = "yellow";
            //        //}
            //        //else
            //        //{
            //        //    IntArray[xCoor, yCoor] = "null";
            //        //}

            //    }

            //}
            //if (greenPoints != null)
            //{
            //    for (int i = 0; i < greenPoints.Count; i++)
            //    {
            //        //System.Diagnostics.Debug.WriteLine(greenPoints[i]);
            //        int xCoor = (int)Math.Floor((decimal)(greenPoints[i].X / 100));
            //        int yCoor = (int)Math.Floor((decimal)((greenPoints[i].Y - 500) / 100));
            //        //if (greenPoints[i].X % 100 > 40 && greenPoints[i].X % 100 < 55 && greenPoints[i].Y % 100 < 35 && greenPoints[i].Y % 100 > 20)
            //        //{
            //        IntArray[xCoor, yCoor] = "green";
            //        //}
            //        //else
            //        //{
            //        //    IntArray[xCoor, yCoor] = "null";
            //        //}

            //    }

            //}
            //if (purplePoints != null)
            //{
            //    for (int i = 0; i < purplePoints.Count; i++)
            //    {
            //        //System.Diagnostics.Debug.WriteLine(purplePoints[i]);
            //        int xCoor = (int)Math.Floor((decimal)(purplePoints[i].X / 100));
            //        int yCoor = (int)Math.Floor((decimal)((purplePoints[i].Y - 500) / 100));
            //        //if (purplePoints[i].X % 100 > 40 && purplePoints[i].X % 100 < 55 && purplePoints[i].Y % 100 < 35 && purplePoints[i].Y % 100 > 20)
            //        //{
            //        IntArray[xCoor, yCoor] = "purple";
            //        //}
            //        //else
            //        //{
            //        //    IntArray[xCoor, yCoor] = "null";
            //        //}
            //    }

            //}
        }

        int count = 0;
        bool isClickLeft = true;

        void playSwap(string deviceID)
        {
            //---------------NEW-------------------------
            int delay = 100;
            scanBoard(deviceID);

            //IntArray[0, 0] = "yellow";
            //IntArray[1, 0] = "blue";
            //IntArray[2, 0] = "red";
            //IntArray[3, 0] = "blue";
            //IntArray[4, 0] = "green";
            //IntArray[5, 0] = "red";
            //IntArray[6, 0] = "yellow";

            //IntArray[0, 1] = "blue";
            //IntArray[1, 1] = "yellow";
            //IntArray[2, 1] = "red";
            //IntArray[3, 1] = "green";
            //IntArray[4, 1] = "green";
            //IntArray[5, 1] = "red";
            //IntArray[6, 1] = "purple";

            //IntArray[0, 2] = "blue";
            //IntArray[1, 2] = "blue";
            //IntArray[2, 2] = "yellow";
            //IntArray[3, 2] = "blue";
            //IntArray[4, 2] = "yellow";
            //IntArray[5, 2] = "blue";
            //IntArray[6, 2] = "purple";

            //IntArray[0, 3] = "green";
            //IntArray[1, 3] = "green";
            //IntArray[2, 3] = "blue";
            //IntArray[3, 3] = "purple";
            //IntArray[4, 3] = "blue";
            //IntArray[5, 3] = "green";
            //IntArray[6, 3] = "green";

            //IntArray[0, 4] = "yellow";
            //IntArray[1, 4] = "purple";
            //IntArray[2, 4] = "green";
            //IntArray[3, 4] = "red";
            //IntArray[4, 4] = "purple";
            //IntArray[5, 4] = "blue";
            //IntArray[6, 4] = "red";
            //bool boardIsMoving = isBoardMoving();
            //while(boardIsMoving)
            //{
            //    scanBoard(deviceID);
            //    boardIsMoving = isBoardMoving();
            //}

            System.Diagnostics.Debug.WriteLine("-------------Result--------------");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    System.Diagnostics.Debug.Write(IntArray[j, i] + " ");
                }
                System.Diagnostics.Debug.WriteLine("\n");
            }

            if (count == 5)
            {
                if(isClickLeft)
                {
                    //Click character bên trái ngoài cùng
                    KAutoHelper.ADBHelper.Tap(deviceID, 110, 174);
                    isClickLeft = false;
                    Delay(delay);
                    if (isStop)
                        return;
                } else
                {
                    //Click character bên phải ngoài cùng
                    KAutoHelper.ADBHelper.Tap(deviceID, 624, 179);
                    isClickLeft = true;
                    Delay(delay);
                    if (isStop)
                        return;
                }

                //Click character 1
                KAutoHelper.ADBHelper.Tap(deviceID, 66, 1081);
                Delay(delay);
                if (isStop)
                    return;
                //Click character 2
                KAutoHelper.ADBHelper.Tap(deviceID, 211, 1088);
                Delay(delay);
                if (isStop)
                    return;
                //Click character 3
                KAutoHelper.ADBHelper.Tap(deviceID, 351, 1085);
                Delay(delay);
                if (isStop)
                    return;
                //Click character 4
                KAutoHelper.ADBHelper.Tap(deviceID, 491, 1088);
                Delay(delay);
                if (isStop)
                    return;
                //Click character 5
                KAutoHelper.ADBHelper.Tap(deviceID, 638, 1083);
                Delay(delay);
                if (isStop)
                    return;
                var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                var bigBombPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BIG_BOMB_BMP);
                var bombPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BOMB_BMP);
                if (bigBombPoint != null)
                {
                    KAutoHelper.ADBHelper.Tap(deviceID, bigBombPoint.Value.X, bigBombPoint.Value.Y);
                    Delay(delay);
                    if (isStop)
                        return;
                }
                if (bombPoint != null)
                {
                    KAutoHelper.ADBHelper.Tap(deviceID, bombPoint.Value.X, bombPoint.Value.Y);
                    Delay(delay);
                    if (isStop)
                        return;
                }
                count = 0;
            }





            //oneTwo: blue blue green
            //oneThree: blue green blue
            //twoThree: green blue blue
            int moveFromX = -1, moveFromY = -1, moveToX = -1, moveToY = -1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (j < 5)
                    {
                        bool oneTwoX = IntArray[j, i] == IntArray[j + 1, i];
                        bool oneThreeX = IntArray[j, i] == IntArray[j + 2, i];
                        bool twoThreeX = IntArray[j + 1, i] == IntArray[j + 2, i];
                        if (oneTwoX)
                        {
                            if (j != 4) //Not last column
                            {
                                //check move horizontal to right
                                if (IntArray[j, i] == IntArray[j + 3, i])
                                {
                                    moveFromX = j + 2;
                                    moveFromY = i;
                                    moveToX = j + 3;
                                    moveToY = i;
                                    break;
                                }
                            }
                            if (i != 4) //Not last row
                            {
                                //check move vertical to down
                                if (IntArray[j, i] == IntArray[j + 2, i + 1])
                                {
                                    moveFromX = j + 2;
                                    moveFromY = i;
                                    moveToX = j + 2;
                                    moveToY = i + 1;
                                    break;
                                }
                            }
                            if (i != 0) //Not first row
                            {
                                //check move vertical to up
                                if (IntArray[j, i] == IntArray[j + 2, i - 1])
                                {
                                    moveFromX = j + 2;
                                    moveFromY = i;
                                    moveToX = j + 2;
                                    moveToY = i - 1;
                                    break;
                                }
                            }
                        }
                        else if (oneThreeX)
                        {
                            if (i != 4) //Not last row
                            {
                                //check move vertical to down
                                if (IntArray[j, i] == IntArray[j + 1, i + 1])
                                {
                                    moveFromX = j + 1;
                                    moveFromY = i;
                                    moveToX = j + 1;
                                    moveToY = i + 1;
                                    break;
                                }
                            }
                            if (i != 0) //Not first row
                            {
                                //check move vertical to up
                                if (IntArray[j, i] == IntArray[j + 1, i - 1])
                                {
                                    moveFromX = j + 1;
                                    moveFromY = i;
                                    moveToX = j + 1;
                                    moveToY = i - 1;
                                    break;
                                }
                            }
                        }
                        else if (twoThreeX)
                        {
                            if (j != 0) //not first column
                            {
                                //check move horizontal to left
                                if (IntArray[j + 1, i] == IntArray[j - 1, i])
                                {
                                    moveFromX = j;
                                    moveFromY = i;
                                    moveToX = j - 1;
                                    moveToY = i;
                                    break;
                                }
                            }
                            if (i != 4) //Not last row
                            {
                                //check move vertical to down
                                if (IntArray[j + 1, i] == IntArray[j, i + 1])
                                {
                                    moveFromX = j;
                                    moveFromY = i;
                                    moveToX = j;
                                    moveToY = i + 1;
                                    break;
                                }
                            }
                            if (i != 0) //Not first row
                            {
                                //check move vertical to up
                                if (IntArray[j + 1, i] == IntArray[j, i - 1])
                                {
                                    moveFromX = j;
                                    moveFromY = i;
                                    moveToX = j;
                                    moveToY = i - 1;
                                    break;
                                }
                            }
                        }
                    }

                    if (i < 3)
                    {
                        bool oneTwoY = IntArray[j, i] == IntArray[j, i + 1];
                        bool oneThreeY = IntArray[j, i] == IntArray[j, i + 2];
                        bool twoThreeY = IntArray[j, i + 1] == IntArray[j, i + 2];
                        if (oneTwoY)
                        {
                            if (i != 2) //Not last row
                            {
                                //check move vertical down
                                if (IntArray[j, i] == IntArray[j, i + 3])
                                {
                                    moveFromX = j;
                                    moveFromY = i + 2;
                                    moveToX = j;
                                    moveToY = i + 3;
                                    break;
                                }
                            }
                            if (j != 6) //Not last column
                            {
                                //check move horizontal to right
                                if (IntArray[j, i] == IntArray[j + 1, i + 2])
                                {
                                    moveFromX = j;
                                    moveFromY = i + 2;
                                    moveToX = j + 1;
                                    moveToY = i + 2;
                                    break;
                                }
                            }
                            if (j != 0) //Not first column
                            {
                                //check move horizontal to left
                                if (IntArray[j, i] == IntArray[j - 1, i + 2])
                                {
                                    moveFromX = j;
                                    moveFromY = i + 2;
                                    moveToX = j - 1;
                                    moveToY = i + 2;
                                    break;
                                }
                            }
                        }
                        else if (oneThreeY)
                        {
                            if (j != 6) //Not last column
                            {
                                //check move horizontal to right
                                if (IntArray[j, i] == IntArray[j + 1, i + 1])
                                {
                                    moveFromX = j;
                                    moveFromY = i + 1;
                                    moveToX = j + 1;
                                    moveToY = i + 1;
                                    break;
                                }
                            }
                            if (j != 0) //Not first column
                            {
                                //check move horizontal to left
                                if (IntArray[j, i] == IntArray[j - 1, i + 1])
                                {
                                    moveFromX = j;
                                    moveFromY = i + 1;
                                    moveToX = j - 1;
                                    moveToY = i + 1;
                                    break;
                                }
                            }
                        }
                        else if (twoThreeY)
                        {
                            if (i != 0) //Not first row
                            {
                                //check move vertical down
                                if (IntArray[j, i + 1] == IntArray[j, i - 1])
                                {
                                    moveFromX = j;
                                    moveFromY = i;
                                    moveToX = j;
                                    moveToY = i - 1;
                                    break;
                                }
                            }
                            if (j != 6) //Not last column
                            {
                                //check move horizontal to right
                                if (IntArray[j, i + 1] == IntArray[j + 1, i])
                                {
                                    moveFromX = j;
                                    moveFromY = i;
                                    moveToX = j + 1;
                                    moveToY = i;
                                    break;
                                }
                            }
                            if (j != 0) //Not first column
                            {
                                //check move horizontal to left
                                if (IntArray[j, i + 1] == IntArray[j - 1, i])
                                {
                                    moveFromX = j;
                                    moveFromY = i;
                                    moveToX = j - 1;
                                    moveToY = i;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            //System.Diagnostics.Debug.Write("----MOVE FROM (" + moveFromX + "," + moveFromY + ") TO (" + moveToX + "," + moveToY + ")---------");
            KAutoHelper.ADBHelper.Swipe(deviceID, moveFromX * 100 + 50, moveFromY * 100 + 550, moveToX * 100 + 50, moveToY * 100 + 550);
            count++;





            //------------------OLD------------------------
            //int aX = 55, aY = 541, delta = 100, delay = 100;
            ////swipe horizontal (left to right)
            //for (int i = 1; i < 6; i++)
            //{
            //    for (int j = 0; j < 6; j++)
            //    {
            //        KAutoHelper.ADBHelper.Swipe(deviceID, aX + j * delta, aY, aX + (j + 1) * delta, aY);
            //        Delay(delay);
            //        if (isStop)
            //            return;
            //    }
            //    aY = 541 + i * delta;
            //}
            //aY = 541;
            ////Click character bên trái ngoài cùng
            //KAutoHelper.ADBHelper.Tap(deviceID, 110, 174);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 1
            //KAutoHelper.ADBHelper.Tap(deviceID, 66, 1081);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 2
            //KAutoHelper.ADBHelper.Tap(deviceID, 211, 1088);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 3
            //KAutoHelper.ADBHelper.Tap(deviceID, 351, 1085);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 4
            //KAutoHelper.ADBHelper.Tap(deviceID, 491, 1088);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 5
            //KAutoHelper.ADBHelper.Tap(deviceID, 638, 1083);
            //Delay(delay);
            //if (isStop)
            //    return;
            //var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
            //var bombPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BOMB_BMP);
            //var bigBombPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BIG_BOMB_BMP);
            //if (bombPoint != null)
            //{
            //    KAutoHelper.ADBHelper.Tap(deviceID, bombPoint.Value.X, bombPoint.Value.Y);
            //    Delay(delay);
            //    if (isStop)
            //        return;
            //}
            //if (bigBombPoint != null)
            //{
            //    KAutoHelper.ADBHelper.Tap(deviceID, bigBombPoint.Value.X, bigBombPoint.Value.Y);
            //    Delay(delay);
            //    if (isStop)
            //        return;
            //}
            //screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
            //var winPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, WIN_BMP);
            //if (winPoint != null)
            //{
            //    return;
            //}
            ////swipe vertical (up to down)
            //for (int k = 1; k < 8; k++)
            //{
            //    for (int l = 0; l < 4; l++)
            //    {
            //        KAutoHelper.ADBHelper.Swipe(deviceID, aX, aY + l * delta, aX, aY + (l + 1) * delta);
            //        Delay(delay);
            //        if (isStop)
            //            return;
            //    }
            //    aX = 55 + k * delta;
            //}
            //aX = 655;
            //aY = 541;
            ////Click character bên phải ngoài cùng
            //KAutoHelper.ADBHelper.Tap(deviceID, 624, 179);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 1
            //KAutoHelper.ADBHelper.Tap(deviceID, 66, 1081);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 2
            //KAutoHelper.ADBHelper.Tap(deviceID, 211, 1088);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 3
            //KAutoHelper.ADBHelper.Tap(deviceID, 351, 1085);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 4
            //KAutoHelper.ADBHelper.Tap(deviceID, 491, 1088);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 5
            //KAutoHelper.ADBHelper.Tap(deviceID, 638, 1083);
            //Delay(delay);
            //if (isStop)
            //    return;
            //screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
            //bombPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BOMB_BMP);
            //bigBombPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BIG_BOMB_BMP);
            //if (bombPoint != null)
            //{
            //    KAutoHelper.ADBHelper.Tap(deviceID, bombPoint.Value.X, bombPoint.Value.Y);
            //    Delay(delay);
            //    if (isStop)
            //        return;
            //}
            //if (bigBombPoint != null)
            //{
            //    KAutoHelper.ADBHelper.Tap(deviceID, bigBombPoint.Value.X, bigBombPoint.Value.Y);
            //    Delay(delay);
            //    if (isStop)
            //        return;
            //}
            //screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
            //winPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, WIN_BMP);
            //if (winPoint != null)
            //{
            //    return;
            //}
            ////swipe horizontal (right to left)
            //for (int i = 1; i < 6; i++)
            //{
            //    for (int j = 0; j < 6; j++)
            //    {
            //        KAutoHelper.ADBHelper.Swipe(deviceID, aX - j * delta, aY, aX - (j + 1) * delta, aY);
            //        Delay(delay);
            //        if (isStop)
            //            return;
            //    }
            //    aY = 541 + i * delta;
            //}
            //aX = 55; 
            //aY = 541;
            ////Click character bên trái ngoài cùng
            //KAutoHelper.ADBHelper.Tap(deviceID, 110, 174);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 1
            //KAutoHelper.ADBHelper.Tap(deviceID, 66, 1081);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 2
            //KAutoHelper.ADBHelper.Tap(deviceID, 211, 1088);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 3
            //KAutoHelper.ADBHelper.Tap(deviceID, 351, 1085);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 4
            //KAutoHelper.ADBHelper.Tap(deviceID, 491, 1088);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 5
            //KAutoHelper.ADBHelper.Tap(deviceID, 638, 1083);
            //Delay(delay);
            //if (isStop)
            //    return;
            //screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
            //bombPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BOMB_BMP);
            //bigBombPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BIG_BOMB_BMP);
            //if (bombPoint != null)
            //{
            //    KAutoHelper.ADBHelper.Tap(deviceID, bombPoint.Value.X, bombPoint.Value.Y);
            //    Delay(delay);
            //    if (isStop)
            //        return;
            //}
            //if (bigBombPoint != null)
            //{
            //    KAutoHelper.ADBHelper.Tap(deviceID, bigBombPoint.Value.X, bigBombPoint.Value.Y);
            //    Delay(delay);
            //    if (isStop)
            //        return;
            //}
            //screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
            //winPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, WIN_BMP);
            //if (winPoint != null)
            //{
            //    return;
            //}
            ////swipe vertical (up to down)
            //for (int k = 1; k < 8; k++)
            //{
            //    for (int l = 0; l < 4; l++)
            //    {
            //        KAutoHelper.ADBHelper.Swipe(deviceID, aX, aY + l * delta, aX, aY + (l + 1) * delta);
            //        Delay(delay);
            //        if (isStop)
            //            return;
            //    }
            //    aX = 55 + k * delta;
            //}
            ////Click character bên phải ngoài cùng
            //KAutoHelper.ADBHelper.Tap(deviceID, 624, 179);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 1
            //KAutoHelper.ADBHelper.Tap(deviceID, 66, 1081);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 2
            //KAutoHelper.ADBHelper.Tap(deviceID, 211, 1088);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 3
            //KAutoHelper.ADBHelper.Tap(deviceID, 351, 1085);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 4
            //KAutoHelper.ADBHelper.Tap(deviceID, 491, 1088);
            //Delay(delay);
            //if (isStop)
            //    return;
            ////Click character 5
            //KAutoHelper.ADBHelper.Tap(deviceID, 638, 1083);
            //Delay(delay);
            //if (isStop)
            //    return;
            //screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
            //bombPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BOMB_BMP);
            //bigBombPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, BIG_BOMB_BMP);
            //if (bombPoint != null)
            //{
            //    KAutoHelper.ADBHelper.Tap(deviceID, bombPoint.Value.X, bombPoint.Value.Y);
            //    Delay(delay);
            //    if (isStop)
            //        return;
            //}
            //if (bigBombPoint != null)
            //{
            //    KAutoHelper.ADBHelper.Tap(deviceID, bigBombPoint.Value.X, bigBombPoint.Value.Y);
            //    Delay(delay);
            //    if (isStop)
            //        return;
            //}

        }

        void playNewBie(string deviceID, int stageX, int stageY)
        {
            //Màn 1.x
            KAutoHelper.ADBHelper.Tap(deviceID, stageX, stageY);
            Delay(delayShort);
            if (isStop)
                return;
            //Click next
            KAutoHelper.ADBHelper.Tap(deviceID, 360, 1204);
            Delay(delayShort);
            if (isStop)
                return;
            //Click fight
            KAutoHelper.ADBHelper.Tap(deviceID, 351, 1202);
            Delay(delayLong);
            if (isStop)
                return;
            var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
            var winPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, WIN_BMP);
            //Chơi đến khi win
            while (winPoint == null)
            {
                playSwap(deviceID);
                screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                winPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, WIN_BMP);
                if (isStop)
                    return;
            }
            if (winPoint != null)
            {
                KAutoHelper.ADBHelper.Tap(deviceID, 498, 1198);
                Delay(delayLong);
                if (isStop)
                    return;
            }
            //Nếu level up
            screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
            var levelUpPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, LEVEL_UP_BMP);
            if (levelUpPoint != null)
            {
                KAutoHelper.ADBHelper.Tap(deviceID, 353, 1003);
                Delay(delayLong);
                if (isStop)
                    return;
            }
        }

        void clickConversation(string deviceID, int delayTime)
        {
            KAutoHelper.ADBHelper.Tap(deviceID, 405, 1174);
            Delay(delayTime);
            if (isStop)
                return;
        }
        void Auto()
        {
            //Lấy ra danh sách devices để dùng
            List<string> devices = new List<string>();
            devices = KAutoHelper.ADBHelper.GetDevices();

            //Chạy từng device
            foreach(var deviceID in devices)
            {
                //Tạo ra 1 luồng xử lí riêng biệt
                Task t = new Task(() =>
                {
                        //------------------START NEW BIE STAGE---------------

                        //Survivor's shelter ...
                        KAutoHelper.ADBHelper.Tap(deviceID, 370, 647);
                        Delay(5000);
                        if (isStop)
                            return;
                        //Pyro said: There's so many
                        clickConversation(deviceID, delayLong);
                        //Caroline said: I'm nearly out of arrows...
                        clickConversation(deviceID, delayLong);
                        //Pyro said: Last can of gas!...
                        clickConversation(deviceID, delayLong);
                        //Caroline said: Even if we're out of ammo...
                        clickConversation(deviceID, 5000);
                        //Ellen said: There! It's Caroline and the others...
                        clickConversation(deviceID, delayLong);
                        //Matthew said: Let's go help them finish ...
                        clickConversation(deviceID, 2000);
                        //Tap the battle icon to fight ...
                        KAutoHelper.ADBHelper.Tap(deviceID, 450, 548);
                        Delay(5000);
                        if (isStop)
                            return;

                        //Kéo từ trên xuống
                        KAutoHelper.ADBHelper.Swipe(deviceID, 355, 539, 355, 638);
                        Delay(3000);
                        if (isStop)
                            return;
                        //Click bomb
                        KAutoHelper.ADBHelper.Tap(deviceID, 355, 634);
                        Delay(5000);
                        if (isStop)
                            return;

                        //click vào thằng người bên phải trên
                        KAutoHelper.ADBHelper.Tap(deviceID, 610, 249);
                        Delay(delayLong);
                        if (isStop)
                            return;
                        //Click vào thẻ cô gái bên phải dưới
                        KAutoHelper.ADBHelper.Tap(deviceID, 578, 1165);
                        Delay(3000);
                        if (isStop)
                            return;

                        //Kéo từ dưới lên
                        KAutoHelper.ADBHelper.Swipe(deviceID, 61, 837, 61, 740);
                        Delay(5000);
                        if (isStop)
                            return;


                        var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                        var upgradeBuildingPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, UPGRADE_BUILDING_BMP);
                        //Chơi đến khi win
                        while (upgradeBuildingPoint == null)
                        {
                            playSwap(deviceID);
                            screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                            upgradeBuildingPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, UPGRADE_BUILDING_BMP);
                            if (isStop)
                                return;
                    }
                        if (upgradeBuildingPoint != null)
                        {
                            Delay(1000);
                            KAutoHelper.ADBHelper.Tap(deviceID, 355, 571);
                            Delay(3000);
                            if (isStop)
                                return;
                        }
                        //Click vào Metal Storage
                        KAutoHelper.ADBHelper.Tap(deviceID, 191, 569);
                        Delay(5000);
                        if (isStop)
                            return;

                        //Click thu hoạch đá
                        KAutoHelper.ADBHelper.Tap(deviceID, 563, 409);
                        Delay(3000);
                        if (isStop)
                            return;

                        //nói chuyện
                        //Matthew said: Great, now that we ha ve resources ...
                        clickConversation(deviceID, delayLong);
                        //Ellen said: Maybe we can use the school bus ...
                        clickConversation(deviceID, delayLong);
                        //Pyro said: Remember to bring enough oil...
                        clickConversation(deviceID, 5000);
                        //Matthew said: Now, let's fill'er up with gas ...
                        clickConversation(deviceID, 2000);
                        //Click vào icon tool
                        KAutoHelper.ADBHelper.Tap(deviceID, 161, 606);
                        Delay(5000);
                        if (isStop)
                            return;

                        //Click claim
                        KAutoHelper.ADBHelper.Tap(deviceID, 353, 1005);
                        Delay(2000);
                        if (isStop)
                            return;

                        //Nói chuyện
                        //Ellen said: Some new survivors want ...
                        clickConversation(deviceID, delayLong);
                        //Matthrew said: They've never been trained ...
                        clickConversation(deviceID, delayLong);
                        //Ellen said: There's a place we can train near ...
                        clickConversation(deviceID, 5000);
                        //Ellen said: Damn. It's overrun with zombies!
                        clickConversation(deviceID, delayLong);
                        //Matthew said: Then let's clean it up
                        clickConversation(deviceID, 3000);
                        //Click vào icon dao vs súng
                        KAutoHelper.ADBHelper.Tap(deviceID, 429, 144);
                        Delay(5000);
                        if (isStop)
                            return;
                        //Colors affect how much damage you can inflict
                        KAutoHelper.ADBHelper.Tap(deviceID, 351, 692);
                        Delay(delayLong);
                        if (isStop)
                            return;
                        //Kéo từ phải qua trái
                        KAutoHelper.ADBHelper.Swipe(deviceID, 653, 835, 552, 835);
                        Delay(2000);
                        if (isStop)
                            return;
                        //Kéo từ phải qua trái
                        KAutoHelper.ADBHelper.Swipe(deviceID, 256, 742, 157, 742);
                        Delay(delayLong);
                        if (isStop)
                            return;
                        screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                        var plusPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, PLUS_BMP);
                        //Chơi đến khi win
                        while (plusPoint == null)
                        {
                            playSwap(deviceID);
                            screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                            plusPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, PLUS_BMP);
                            if (isStop)
                                return;
                    }
                        if (plusPoint != null)
                        {
                            KAutoHelper.ADBHelper.Tap(deviceID, 340, 124);
                            Delay(2000);
                            if (isStop)
                                return;
                            KAutoHelper.ADBHelper.Tap(deviceID, 340, 124);
                            Delay(2000);
                            if (isStop)
                                return;
                        }

                        //Click vào dấu cộng to
                        KAutoHelper.ADBHelper.Tap(deviceID, 113, 569);
                        Delay(2000);
                        if (isStop)
                            return;
                    //Click vào thằng Pyro
                        screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                        var pyroPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, PYRO_BMP);
                    if (pyroPoint != null)
                    {
                        KAutoHelper.ADBHelper.Tap(deviceID, pyroPoint.Value.X, pyroPoint.Value.Y);
                        Delay(2000);
                        if (isStop)
                            return; 
                    }     
                        //Click begin prroduction
                        KAutoHelper.ADBHelper.Tap(deviceID, 554, 398);
                        Delay(1000);
                        if (isStop)
                            return;
                        //Click produce
                        KAutoHelper.ADBHelper.Tap(deviceID, 478, 373);
                        Delay(1000);
                        if (isStop)
                            return;
                        //Click produce tiếp
                        KAutoHelper.ADBHelper.Tap(deviceID, 351, 1003);
                        Delay(2000);
                        if (isStop)
                            return;
                        //Click claim
                        KAutoHelper.ADBHelper.Tap(deviceID, 357, 824);
                        Delay(1000);
                        if (isStop)
                            return;
                        //Click x đỏ
                        KAutoHelper.ADBHelper.Tap(deviceID, 673, 116);
                        Delay(1000);
                        if (isStop)
                            return;
                        //Click fighterrs
                        KAutoHelper.ADBHelper.Tap(deviceID, 189, 1219);
                        Delay(1000);
                        if (isStop)
                            return;
                        //Click thằng bên trái ngoài cùng
                        KAutoHelper.ADBHelper.Tap(deviceID, 70, 360);
                        Delay(1000);
                        if (isStop)
                            return;
                        //Click level up
                        KAutoHelper.ADBHelper.Tap(deviceID, 120, 1198);
                        Delay(1000);
                        if (isStop)
                            return;
                        //Click vào quả pháo
                        KAutoHelper.ADBHelper.Tap(deviceID, 68, 798);
                        Delay(1000);
                        if (isStop)
                            return;
                        //Click level up
                        KAutoHelper.ADBHelper.Tap(deviceID, 619, 584);
                        Delay(7000);
                        if (isStop)
                            return;
                        //Click ok
                        KAutoHelper.ADBHelper.Tap(deviceID, 366, 1213);
                        Delay(2000);
                        if (isStop)
                            return;
                        //nói chuyện
                        //Pyro said: Matthew, Matthew, are you there? ...
                        clickConversation(deviceID, delayLong);
                        //Matthew said: It's Matthew. What's the situation ...
                        clickConversation(deviceID, delayLong);
                        //Pyro said: We've gone through the whole...
                        clickConversation(deviceID, delayLong);
                        //Matthew said: That's some good news, at least.
                        clickConversation(deviceID, delayLong);
                        //Pyro said: Gotta remind you ...
                        clickConversation(deviceID, delayLong);
                        //Matthew said: Thanks for the reminder...
                        clickConversation(deviceID, 7000);
                        //Click bậc thang
                        KAutoHelper.ADBHelper.Tap(deviceID, 139, 258);
                        Delay(1000);
                        if (isStop)
                            return;
                        //Click upgrade
                        KAutoHelper.ADBHelper.Tap(deviceID, 297, 710);
                        Delay(1000);
                        if (isStop)
                            return;
                        //Click upgrade tiếp
                        KAutoHelper.ADBHelper.Tap(deviceID, 342, 928);
                        Delay(6000);
                        if (isStop)
                            return;

                        //Click map
                        KAutoHelper.ADBHelper.Tap(deviceID, 351, 1211);
                        Delay(1000);
                        if (isStop)
                            return;
                        //Click man 1
                        KAutoHelper.ADBHelper.Tap(deviceID, 416, 323);
                        Delay(1000);
                        if (isStop)
                            return;
                        //nói chuyện
                        //Ellen said: This place is a disaster...
                        clickConversation(deviceID, delayLong);
                        //Matthew said: Books. The accumulated ...
                        clickConversation(deviceID, delayLong);
                        //Matthew said: If we're going to rebuild ...
                        clickConversation(deviceID, delayLong);
                        //Matthew said: Let's secure this place and see ...
                        clickConversation(deviceID, delayLong);

                        //------------------END NEW BIE STAGE




                        ////Nếu có lệnh stop thì dừng toàn bộ
                        //if (isStop)
                        //    return;



                       

                });
                t.Start();
            }
        }


        void Delay(int delay)
        {
                while(delay > 0)
                {
                    Thread.Sleep(TimeSpan.FromMilliseconds(1));
                    delay--;
                    if (isStop)
                        break;
                }
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            isStop = true;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //Lấy ra danh sách devices để dùng
            List<string> devices = new List<string>();
            devices = KAutoHelper.ADBHelper.GetDevices();

            //Chạy từng device
            foreach (var deviceID in devices)
            {
                //Tạo ra 1 luồng xử lí riêng biệt
                Task t1 = new Task(() =>
                {
                    /*------------------START PVP----------------*/

                    while(true)
                    {
                        //Click find opponent
                        KAutoHelper.ADBHelper.Tap(deviceID, 353, 1182);
                        Delay(1000);
                        if (isStop)
                            return;

                        //Click fight
                        KAutoHelper.ADBHelper.Tap(deviceID, 364, 1206);
                        Delay(2000);
                        if (isStop)
                            return;

                        var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                        var winPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, WIN_PVP_BMP);
                        //Chơi đến khi win
                        while (winPoint == null)
                        {
                            playSwap(deviceID);
                            screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID, false);
                            winPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, WIN_PVP_BMP);
                            if (isStop)
                                return;
                        }
                        if (winPoint != null)
                        {
                            //Click next (lose)
                            KAutoHelper.ADBHelper.Tap(deviceID, 585, 1156);
                            Delay(2000);
                            if (isStop)
                                return;
                            //Click next (win)
                            KAutoHelper.ADBHelper.Tap(deviceID, 455, 1137);
                            Delay(2000);
                            if (isStop)
                                return;
                        }
                    }
                    



                    /*------------------END STAGE 2----------------*/
                });
                t1.Start();
            }
         }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/C memuc listvms -r";
            //p.StartInfo.Arguments = "/C adb connect localhost:21523";
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            System.Diagnostics.Debug.WriteLine($"Current devices: {output}");
            string[] arrListStr = output.Split('\n');

            //Đoạn này để cmd ko bị treo
            p.StartInfo.Arguments = $"/C adb devices";
            p.Start();
            p.WaitForExit();
            for (int i = 0; i < arrListStr.Length; i++)
            {
                if (arrListStr[i].Length > 0)
                {
                    char currentDevice = arrListStr[i][0];
                    if (currentDevice - '0' >= 0)
                    { 
                        p.StartInfo.Arguments = $"/C adb connect 127.0.0.1:215{currentDevice}3";
                        p.Start();

                        output = p.StandardOutput.ReadToEnd();
                        p.WaitForExit();
                        System.Diagnostics.Debug.WriteLine(output);
                        MessageBox.Show(output, "Connect devices");
                    }     
                   
                }
            }

        }
    }
}
