﻿using CleanArchitectureFinanceImportAutomator._02_Domain;
using CleanArchitectureFinanceImportAutomator._04_CrossCutting;
using System.Collections.Generic;

namespace CleanArchitectureFinanceImportAutomator._01_Application
{
    public interface IFileReader : IInteractor<string, IEnumerable<string>> { }
}
