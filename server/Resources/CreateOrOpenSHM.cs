using System.Threading.Tasks;
using System.IO.MemoryMappedFiles;

namespace CreateOrOpenSHM
{
	public class Startup
	{
        public async Task<object> Invoke(object memoryMapName)
        {
            try
            {
                SHMV v;
                v.value1 = 0;
                v.value2 = 0;
                v.value3 = 0;
                v.value4 = 0;
                v.value5 = 0;

                MemoryMappedFile mmf = MemoryMappedFile.CreateOrOpen((string) memoryMapName, 100000);
                var accessor = mmf.CreateViewAccessor();
                accessor.Write<SHMV>(0, ref v);

                return "SUCCESS";
            }
            catch
            {
                return "FAIL";
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
