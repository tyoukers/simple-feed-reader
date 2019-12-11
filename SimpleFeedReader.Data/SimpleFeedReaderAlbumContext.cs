using Microsoft.EntityFrameworkCore;
using SimpleFeedReader.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFeedReader.Data2
{
    public class SimpleFeedReaderAlbumContext : DbContext
    {

        public SimpleFeedReaderAlbumContext(DbContextOptions<SimpleFeedReaderAlbumContext> options) : base(options)
        {

        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }

    }
}
