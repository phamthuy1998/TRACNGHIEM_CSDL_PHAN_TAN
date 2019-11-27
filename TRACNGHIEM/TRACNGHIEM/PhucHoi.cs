using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TRACNGHIEM
{
    class PhucHoi
    {
        private string lenh1;
        private string lenh2;
        private string loaiCauLenh;

        public PhucHoi(string lenh1, string lenh2, string loaiCauLenh)
        {
            this.lenh1 = lenh1;
            this.lenh2 = lenh2;
            this.loaiCauLenh = loaiCauLenh;
        }

        public string cauLenh1
        {
            get { return lenh1; }
            set { lenh1 = value; }
        }

        public string cauLenh2
        {
            get { return lenh2; }
            set { lenh2 = value; }
        }

        public string LoaiCauLenh
        {
            get { return loaiCauLenh; }
            set { loaiCauLenh = value; }
        }

    }
}
