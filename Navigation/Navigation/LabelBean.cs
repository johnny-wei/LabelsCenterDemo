using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation
{
    public class LabelBean
    {
        public string 产品类别编码 { set; get; }
        public string 产品类别名称 { set; get; }
        public static List<LabelBean> LabelBeans { get; set; }
        static LabelBean()
        {
            LabelBeans = new List<LabelBean>();

            Random random = new Random();
            int count = random.Next(20, 200);
            for (int i = 1; i <= count; i++)
            {
                LabelBean stu = new LabelBean
                {
                    产品类别编码 = "123456" + i,
                    //Age = random.Next(20, 50),
                    //Gender = (i % 3 != 0),
                    //Desc = "Desc " + i
                    产品类别名称 = "产品类别名称" + i,
                };
                LabelBeans.Add(stu);
            }
        }
    } 
}
