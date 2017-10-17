using Blank.AspNetCore.Abstract.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blank.AspNetCore.Abstract
{
    public interface IMenuBuilder
    {
        MainMenu GetMenu();
    }
}
