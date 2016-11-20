﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBaseOrchestration.API.Data.Interfaces;

namespace MyBaseOrchestration.API.Buisness.Managers
{
    internal abstract class RepositoryManager<repoType> where repoType : IRepository
    {
        public readonly repoType _repository;         

        public RepositoryManager(repoType repo)
        {
            if (repo == null) throw new ArgumentNullException("Repository");
            _repository = repo;
        }
    }
}
