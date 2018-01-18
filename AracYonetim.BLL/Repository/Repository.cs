

using AracYonetim.Entities.Models;
using System;

namespace AracYonetim.BLL.Repository
{
     public class MarkaRepo : RepositoryBase<Marka, int> { }

    public class AracRepo : RepositoryBase<Arac, Guid> { }
    //ekstra metot yazmak gerekiyorsa her sınıfın içerisine tanımlanmalıdır

}
