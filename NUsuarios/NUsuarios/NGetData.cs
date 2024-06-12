using System.Data;
using Data;

namespace NUsuarios
{
    public class NGetData
    {

        public DataTable GetUsuarios(string sql ) {

            GetData data = new GetData();
            var result = data.GetUsuarios(sql);


            return result;
        
        
        }
    }
}
