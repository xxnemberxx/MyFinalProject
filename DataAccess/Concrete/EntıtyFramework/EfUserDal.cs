using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntıtyFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new NorthwindContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                             on operationClaim.ClaimId equals userOperationClaim.ClaimId
                             where userOperationClaim.UserId == user.UserId
                             select new OperationClaim
                             {
                                 ClaimId = operationClaim.ClaimId,
                                 Name = operationClaim.Name
                             };

                return result.ToList();
            }
        }

    }
}
