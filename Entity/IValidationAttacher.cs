﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public interface IValidationAttacher
    {
        bool ValidateSize(string path);
    }
}
