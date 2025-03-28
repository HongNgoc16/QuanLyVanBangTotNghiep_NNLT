using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVanBangTotNghiep.Entity
{
    public class Dm_DotCapVanBang
    {
        private int _Id_Dot_Cap;
        private string _Ten_Van_Bang;
        private string _Ten_Dot_Cap;

        public Dm_DotCapVanBang() { }

        public int Id_Dot_Cap
        {
            get { return _Id_Dot_Cap; }
            set { _Id_Dot_Cap = value; }
        }
        public string Ten_Van_Bang
        {
            get { return _Ten_Van_Bang; }
            set { _Ten_Van_Bang = value; }
        }
        public string Ten_Dot_Cap
        {
            get { return _Ten_Dot_Cap; }
            set { _Ten_Dot_Cap = value; }
        }
    }


}
