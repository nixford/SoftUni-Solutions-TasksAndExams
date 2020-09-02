﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.HTTP.Enums
{
    public enum HttpResponseCode
    {
        Ok = 200,
        MovedPermanently = 301,
        TemporaryRedirect = 307,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,
        InternalServerError = 500,
        NotImplemented = 501,
    }
}
