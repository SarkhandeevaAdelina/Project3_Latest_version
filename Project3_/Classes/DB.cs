using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Project3_
{
    class DB
    {
        private static SqlConnection connection = null;
        public static SqlConnection Connection
        {
            get
            {
                return connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Пользователь\OneDrive\Рабочий стол\Project3_-master\Project3_\Database\Ration.mdf"";Integrated Security=True");
            }
        }

    }
}
