﻿using EC_API.Data;
using EC_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EC_API._Repositories.Interface
{
   public interface IArticleNoRepository: IECRepository<ArticleNo>
    {
        Task<object> GetArticleNoByModelNameID(int modelNameID);
    }
}
