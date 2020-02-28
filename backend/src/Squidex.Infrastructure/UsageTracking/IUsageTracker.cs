﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschränkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Squidex.Infrastructure.UsageTracking
{
    public interface IUsageTracker
    {
        Task TrackAsync(DateTime date, string key, string? category, Counters counters);

        Task<Counters> GetForMonthAsync(string key, DateTime date);

        Task<Counters> GetAsync(string key, DateTime fromDate, DateTime toDate);

        Task<Dictionary<string, List<(DateTime Date, Counters Counters)>>> QueryAsync(string key, DateTime fromDate, DateTime toDate);
    }
}
