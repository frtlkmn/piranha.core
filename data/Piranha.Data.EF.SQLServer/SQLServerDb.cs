/*
 * Copyright (c) 2020 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * http://github.com/piranhacms/piranha
 *
 */

using Microsoft.EntityFrameworkCore;

namespace Piranha.Data.EF.SQLServer
{
    public sealed class SQLServerDb : Db<SQLServerDb>
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="options">Configuration options</param>
        public SQLServerDb(DbContextOptions<SQLServerDb> options) : base(options)
        {
        }
    }
}