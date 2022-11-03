using System.Threading.Tasks;
using System.IO.MemoryMappedFiles;

namespace GetSHMDataValues
{
	public class Startup
	{
        public async Task<object> Invoke(object memoryMapName)
        {
            try
            {
                SHMV v;

                MemoryMappedFile mmf = MemoryMappedFile.OpenExisting((string) memoryMapName);
                MemoryMappedViewStream stream = mmf.CreateViewStream(0, 12);
                var accessor = mmf.CreateViewAccessor();
                accessor.Read<SHMV>(0, out v);

                return "{ \"value1\": " + v.value1 + ", \"value2\": " + v.value2 + ", \"value3\": " + v.value3 + ", \"value4\": " + v.value4 + ", \"value5\": " + v.value5 + " }";

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
