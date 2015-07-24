using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Object
{
    public class Avatar
    {
        public int id { get; set; }

        public string pathAvatar { get; set; }
    }

    public class AvatarView : Avatar
    {
        public bool newRegister { get; set; }
    }

    public class AvatarRequest : Avatar { }

    public class AvatarIndex
    {
        public List<Avatar> Avatars { get; set; }
    }
}
