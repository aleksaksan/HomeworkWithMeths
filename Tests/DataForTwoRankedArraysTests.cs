using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMethods
{
    public class TestData
    {
        public static int[,] GetArrayForChangeSignTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1 } },
                1 => new int[,] {   { 1, 1 }, 
                                    { 1, 1 } },

                2 => new int[,] {   { 1, 1, 1, 1 }, 
                                    { 1, 1, 1, 1 },
                                    { 1, 1, 1, 1 },
                                    { 1, 1, 1, 1 } },
                3 => new int[,] {   { 1, 1, 1 } },
                _ => new int[,] {   {   } }
            };
        }
        public static int[,] GetAnswerForChangeSignTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { -1 } },
                1 => new int[,] {   { -1, -1 }, 
                                    { -1, -1 } },

                2 => new int[,] {   { -1, -1, -1, -1 }, 
                                    { -1, 1, 1, -1 }, 
                                    { -1, 1, 1, -1 },
                                    { -1, -1, -1, -1 }},
                3 => new int[,] {   { -1, -1, -1 } },
                _ => new int[,] {   {   } }
            };
        }
        public static int[,] GetArrayChessDescTest(int index)
        {
            return index switch
            {
                1 => new int[,] { { 0 } },
                2 => new int[,] {   { 1, 0 }, 
                                    { 0, 1 } },

                4 => new int[,] {   { 1, 0, 1, 0 },
                                    { 0, 1, 0, 1 }, 
                                    { 1, 0, 1, 0 },
                                    { 0, 1, 0, 1 }},

                5 => new int[,] {   { 0, 1, 0, 1, 0 },
                                    { 1, 0, 1, 0, 1 },
                                    { 0, 1, 0, 1, 0 },
                                    { 1, 0, 1, 0, 1 },
                                    { 0, 1, 0, 1, 0 },},
                _ => new int[,] { {   } }
            };
        }
        public static byte[,] GetArrayForCheckCovidTest(int index)
        {
            return index switch
            {
                1 => new byte[,] { { 0 } },
                2 => new byte[,] {   { 1, 0 },
                                    { 0, 1 } },

                3 => new byte[,] {   { 1, 0, 1, 0 },
                                    { 0, 1, 0, 1 },
                                    { 1, 0, 1, 0 },
                                    { 0, 1, 0, 1 }},
                4 => new byte[,] {   { 0, 0, 1, 0 },
                                    { 0, 1, 0, 1 },
                                    { 1, 0, 1, 0 },
                                    { 0, 0, 1, 1 }},

                5 => new byte[,] {   { 0, 1, 0, 1, 0 },
                                    { 1, 0, 1, 0, 1 },
                                    { 0, 1, 0, 1, 0 },
                                    { 1, 0, 1, 0, 1 },
                                    { 0, 1, 1, 1, 0 },},
                _ => new byte[,] { { } }
            };
        }
        public static double[,] GetArrayShopsTest(int index)
        {
            return index switch
            {
                1 => new double[,] {  { 0, 0, 0, 0, 0, 0 }, //6 mounths, 4 shops
                                    { 0, 0, 0, 0, 0, 0 },
                                    { 0, 0, 0, 0, 0, 0 },
                                    { 0, 0, 0, 0, 0, 0 } },

                2 => new double[,] {  { 1, 0, 0, 0, 0, 0 }, //6 mounths, 4 shops
                                    { 0, 1, 0, 0, 0, 0 },
                                    { 0, 0, 1, 0, 0, 0 },
                                    { 0, 0, 0, 1, 0, 0 } },

                3 => new double[,] {  { 1.1, 1.1, 1.1, 1.1, 1.1, 1.1 }, //6 mounths, 4 shops
                                    { 1.1, 1.1, 1.1, 1.1, 1.1, 1.1 },
                                    { 1.1, 1.1, 1.1, 1.1, 1.1, 1.1 },
                                    { 1.1, 1.1, 1.1, 1.1, 1.1, 1.1 } },
                4 => new double[,] { { },{ },{ } },  //3 shops, 0 mounths
                _ => new double[,] { { } }  //0 shops
            };
        }
        public static double[,] GetArrayMinMaxForShopTest(int index)
        {
            return index switch
            {
                1 => new double[,] {  { 0, 0 }, //6 mounths, 4 shops
                                    { 0, 0 },
                                    { 0, 0 },
                                    { 0, 0 } },

                2 => new double[,] {  { 0, 1 }, //6 mounths, 4 shops
                                    { 0, 1 },
                                    { 0, 1 },
                                    { 0, 1 } },

                3 => new double[,] {  { 1.1, 1.1 }, //6 mounths, 4 shops
                                    { 1.1, 1.1 },
                                    { 1.1, 1.1 },
                                    { 1.1, 1.1 } },
                4 => new double[,] { { }, { }, { } },  //3 shops, 0 mounths
                _ => new double[,] { { } }  //0 shops
            };
        }
        public static int[,] GetArrayForCountOfBiggersTest(int index)
        {
            return index switch
            {
                0 => new int[,]
                {
                    { 0, 1, 0, 0, 1 },
                    { 0, 0, 0, 0, 0 },
                    { 1, 0, 0, 0, 1 },
                    { 0, 0, 1, 0, 0 },
                },
                1 => new int[,] // = 0
                {
                    { 1, 1, 1, 1, 0 }, //0
                    { 0, 0, 0, 1, 0 }, //0
                    { 0, 0, 0, 1, 0 }, //0
                    { 1, 1, 0, 1, 0 }, //0
                }, 
                2 => new int[,] // = 9
                {
                    { 1, 0, 1, 0, 1 }, //3
                    { 0, 0, 0, 0, 0 }, //0
                    { 1, 0, 1, 0, 1 }, //3
                    { 0, 0, 0, 0, 0 }, //0
                    { 1, 0, 1, 0, 1 }, //3
                },
                3 => new int[,] // = 4
                {
                    { 1, 0, 1, 0, 1 }, //2
                    { 0, 0, 1, 0, 0 }, //0
                    { 1, 1, 0, 1, 1 }, //0
                    { 0, 0, 1, 0, 0 }, //0
                    { 1, 0, 1, 0, 1 }, //2
                },
                4 => new int[,] // = 0
                {
                    { 1, 1, 0, 1, 1 }, //0
                    { 1, 1, 0, 1, 1 }, //0
                    { 1, 1, 0, 1, 1 }, //0
                    { 1, 1, 0, 1, 1 }, //0
                    { 1, 1, 0, 1, 1 }, //0
                },
                5 => new int[,] // = 0
                {
                    { 1, 1, 1, 1, 1 }, //0
                    { 1, 1, 1, 1, 1 }, //0
                    { 0, 0, 0, 0, 0 }, //0
                    { 1, 1, 1, 1, 1 }, //0
                    { 1, 1, 1, 1, 1 }, //0
                },
                6 => new int[,] // = 12
                {
                    { 0, 1, 0, 1, 0 }, //2
                    { 1, 0, 1, 0, 1 }, //3
                    { 0, 1, 0, 1, 0 }, //2
                    { 1, 0, 1, 0, 1 }, //3
                    { 0, 1, 0, 1, 0 }, //2
                },
                _ => new int[,] { { } }
            };
        }

        public static int[,] GetArrayMultiThirstTest(int index)
        {
            return index switch
            {
                0 => new int[,]
                {
                    { 2, -3, 1 },
                    { 5, 4, -2 },
                },
                1 => new int[,] 
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                },
                2 => new int[,]
                {
                    { 9, 3, 5 },
                    { 2, 0, 3 },
                    { 0, 1, -6 },
                },
                3 => new int[,]
                {
                    { 1, 2, 0 },
                    { 3, 1, -1 },

                },
                _ => new int[,] {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                },
            };
        }
        public static int[,] GetArrayMultiSecondTest(int index)
        {
            return index switch
            {
                0 => new int[,]
                {
                    { -7, 5 },
                    { 2, -1 },
                    { 4,  3 },
                },
                1 => new int[,]  
                {
                    { 7, 8 },
                    { 9, 1 },
                    { 2, 3 },
                },
                2 => new int[,]
                {
                    { 1, -1, -1 },
                    { -1, 4, 7 },
                    { 8, 1, -1 },
                },
                3 => new int[,]
                {
                    { 1 },
                    { 2 },
                    { 3 },

                },
                _ => new int[,] {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                },
            };
        }
        public static int[,] GetArrayMultiAnswerTest(int index)
        {
            return index switch
            {
                0 => new int[,]
                {
                    { -16, 16 },
                    { -35, 15 },
                },
                1 => new int[,]
                {
                    { 31, 19 },
                    { 85, 55 },
                },
                2 => new int[,]
                {
                    { 46, 8, 7 },
                    { 26, 1, -5 },
                    { -49, -2, 13 },
                },
                3 => new int[,]
                {
                    { 5 },
                    { 2 },
                },
                _ => new int[,] { { } } // argument exception needed
            };
        }
    }
}
