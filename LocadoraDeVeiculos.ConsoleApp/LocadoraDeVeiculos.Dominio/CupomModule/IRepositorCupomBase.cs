using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Dominio.Shared;


namespace LocadoraDeVeiculos.DOminio.CupomModule
{
    public interface IRepositorCupomBase : IRepositorBase<Cupom>
    {
        public abstract bool EditarQtdUsos (Cupom cupom);

        public abstract Cupom SelecionarPorCodigo(string codigo);

        public abstract List<Cupom> SelecionarValidos();

    }
}
