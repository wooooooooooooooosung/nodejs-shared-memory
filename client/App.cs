using System;
using System.Diagnostics;
using System.IO.MemoryMappedFiles;
using System.Windows.Forms;

namespace SHM
{
    internal static class App
    {
        static MemoryMappedFile mmf;
        static MemoryMappedViewStream stream;
        static SHMV v;


        /// <summary>
        /// 해당 Application 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Debug.WriteLine("[Log] Start Application");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SHMForm());
        }

        /// <summary>
        /// 메모리 맵에 접근한다.
        /// </summary>
        /// <param name="memoryMapName">접근할 메모리 맵 이름</param>
        /// <returns>메모리 맵 접근 성공 여부</returns>
        public static bool AccessSHMMap(string memoryMapName)
        {
            try
            {
                mmf = MemoryMappedFile.OpenExisting(memoryMapName);
                return true;
            } 
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 메모리 맵의 데이터를 가져온다.
        /// </summary>
        /// <returns>현재 메모리 맵에 들어있는 데이터 리스트</returns>
        public static int[] GetSHMDataValue()
        {
            stream = mmf.CreateViewStream(0, 12);
            var accessor = mmf.CreateViewAccessor();
            accessor.Read<SHMV>(0, out v);

            return new int[] { v.value1, v.value2, v.value3, v.value4, v.value5 };
        }

        /// <summary>
        /// 메모리 맵의 데이터 값을 변경한다.
        /// </summary>
        /// <param name="param1">메모리 맵의 첫번째 값</param>
        /// <param name="param2">메모리 맵의 두번째 값</param>
        /// <param name="param3">메모리 맵의 세번째 값</param>
        /// <param name="param4">메모리 맵의 네번째 값</param>
        /// <param name="param5">메모리 맵의 다섯번째 값</param>
        /// <returns>메모리 맵 데이터 값 변경 성공 여부</returns>
        public static bool SetSHMDataValue(int param1, int param2, int param3, int param4, int param5)
        {
            try
            {
                var accessor = mmf.CreateViewAccessor();
                
                v.value1 = param1;
                v.value2 = param2;
                v.value3 = param3;
                v.value4 = param4;
                v.value5 = param5;

                accessor.Write<SHMV>(0, ref v);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    struct SHMV
    {
        public int value1;
        public int value2;
        public int value3;
        public int value4;
        public int value5;
    }
}
