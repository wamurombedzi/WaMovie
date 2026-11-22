#define Second
#if First
// <snippet_First>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WaMovie.Models;

namespace WaMovie.Data
{
    public class WaMovieContext : DbContext
    {
        public WaMovieContext (DbContextOptions<WaMovieContext> options)
            : base(options)
        {
        }

        public DbSet<WaMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
// </snippet_First>
#endif
#if Second
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WaMovie.Models;

namespace WaMovie.Data
{
    public class WaMovieContext : DbContext
    {
        public WaMovieContext(DbContextOptions<WaMovieContext> options)
            : base(options)
        {
        }

        // <snippet_NRTChange>
        public DbSet<WaMovie.Models.Movie> Movie { get; set; } = null!;
        // </snippet_NRTChange>
    }
}
#endif