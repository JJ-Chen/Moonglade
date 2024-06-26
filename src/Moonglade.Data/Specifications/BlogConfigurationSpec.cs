﻿using Moonglade.Data.Entities;

namespace Moonglade.Data.Specifications;

public sealed class BlogConfigurationSpec : SingleResultSpecification<BlogConfigurationEntity>
{
    public BlogConfigurationSpec(string cfgKey)
    {
        Query.Where(p => p.CfgKey == cfgKey);
    }
}