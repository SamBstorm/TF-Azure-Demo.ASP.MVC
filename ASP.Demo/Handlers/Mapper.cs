using ASP.Demo.Models;
using ASP.Demo.Models.ViewModels;

namespace ASP.Demo.Handlers
{
    public static class Mapper
    {
        public static MagasinListItem ToListItem(this Magasin entity)
        {
            if(entity == null) return null;
            return new MagasinListItem()
            {
                ID = entity.MagasinId,
                Nom = entity.Nom,
                Ville = entity.Ville,
                Pays = entity.Pays
            };
            /*MagasinListItem result = new MagasinListItem();
            result.ID = entity.MagasinId;
            result.Nom = entity.Nom;
            result.Ville = entity.Ville;
            result.Pays = entity.Pays;
            return result;*/
        }

        public static Magasin ToMagasin(this MagasinCreateForm entity)
        {
            if (entity == null) return null;
            return new Magasin()
            {
                Nom = entity.Nom,
                Rue = entity.Rue,
                Numero = entity.Numero,
                Ville = entity.Ville,
                CodePostal = entity.CodePostal,
                Pays = entity.Pays
            };
        }
    }
}
