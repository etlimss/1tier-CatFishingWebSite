﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatFishingWebSite.Services
{
    public enum RequestTypes
    {
        GETUSER,
        LOGIN,
        LOGOUT,
        CREATEUSER,
        //edit
        EDITFISHER,
        GETFISHER,
        //Match
        MATCHLIST,
        LIKE,
        REJECT,
        //History
        HISTORY
        //Chat

    }
}
