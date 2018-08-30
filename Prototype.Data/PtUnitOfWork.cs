using Prototype.Data.Repository.EF;

namespace Prototype.Data
{
    /// <summary>
    /// PtUnitOfWork class is a unit of work for manipulating about utility data in database via repository.
    /// </summary>
    public class PtUnitOfWork : EfUnitOfWork<DSDBContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtUnitOfWork" /> class.
        /// </summary>
        /// <param name="dsDbContext">The Digital Signature database context what inherits from DbContext of EF.</param>
        public PtUnitOfWork(DSDBContext dsDbContext) : base(dsDbContext)
        { }
    }
}
