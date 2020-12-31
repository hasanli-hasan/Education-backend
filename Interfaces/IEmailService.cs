<<<<<<< HEAD
﻿
using System;
=======
﻿using System;
>>>>>>> 1a962eb45d01c0532e1414845260e27174fb66ee
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationBackendFinal.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(List<string> email, string subject, string message);
    }
}
