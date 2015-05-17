#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace WcfService.Services
{
	using Telerik.OpenAccess;
	using System.Linq.Dynamic;
	using DataLayer;
	using WcfService.Dto;
	using WcfService.Assemblers;
	using WcfService.Repositories;
	using WcfService.Converters;
	using System;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.Serialization;

	
	public partial interface IService<TDto, TEntity>
	    where TEntity : class
		where TDto : IDtoWithKey
	{
	    IAssembler<TDto, TEntity> Assembler { get; }
	    IRepository<TEntity> Repository { get; }
	
	    IEnumerable<TDto> Find(Expression<Func<TEntity, bool>> filter);
	    IEnumerable<TDto> GetAll();
		
		IEnumerable<TDto> Find(int startRowIndex, int maximumRows);
	    IEnumerable<TDto> Find(string sortExpression, string filterExpression);
	    IEnumerable<TDto> Find(int? startRowIndex, int? maximumRows, string sortExpression, string filterExpression);
	    
		int Count();
	    int Count(string filterExpression);
		
		TDto GetByKey(string dtoKey);
	    string Add(TDto dto);
		void Update(TDto dto);
	    void Delete(TDto dto);	
	}
	
	public abstract partial class Service<TDto, TEntity> : IService<TDto, TEntity>
	    where TEntity : class
		where TDto : IDtoWithKey
	{
	    IAssembler<TDto, TEntity> assembler;
	    IRepository<TEntity> repository;
	
	    public Service(IAssembler<TDto, TEntity> assembler,
	        IRepository<TEntity> repository)
	    {
	        this.assembler = assembler;
	        this.repository = repository;
	    }
	
	    public IAssembler<TDto, TEntity> Assembler 
	    { 
	        get 
	        {
	            return this.assembler; 
	        } 
	    }
	
	    public IRepository<TEntity> Repository 
	    { 
	        get 
	        {
	            return this.repository; 
	        }
	    }
		
		public virtual IEnumerable<TDto> GetAll()
	    {
	        return this.assembler.Assemble(this.Repository.GetAll());
	    }
	
	    public virtual IEnumerable<TDto> Find(Expression<Func<TEntity, bool>> filter)
	    {
	        return this.Assembler.Assemble(this.Repository.Find(filter));
	    }
	
	    public virtual IEnumerable<TDto> Find(int startRowIndex, int maximumRows)
	    {
	        return this.Find(startRowIndex, maximumRows, null, null);
	    }
	
	    public virtual IEnumerable<TDto> Find(string sortExpression, string filterExpression)
	    {
	        return this.Find(null, null, sortExpression, filterExpression);
	    }
	
	    public virtual IEnumerable<TDto> Find(int? startRowIndex, int? maximumRows, string sortExpression, string filterExpression)
	    {
	        IQueryable<TEntity> query = this.Repository.GetAll();
	
	        if (!string.IsNullOrEmpty(filterExpression))
	        {
	            query = query.Where(filterExpression);
	        }
	        if (!string.IsNullOrEmpty(sortExpression))
	        {
	            query = query.OrderBy(sortExpression);
	        }
	        if (startRowIndex.HasValue)
	        {
	            query = query.Skip(startRowIndex.Value);
	        }
	        if (maximumRows.HasValue)
	        {
	            query = query.Take(maximumRows.Value);
	        }
	
	        return this.Assembler.Assemble(query);
	    }
	
	    public virtual int Count()
	    {
	        return this.Count(string.Empty);
	    }
	
	    public virtual int Count(string filterExpression)
	    {
	        IQueryable<TEntity> query = this.Repository.GetAll();
	
	        if (!string.IsNullOrEmpty(filterExpression))
	        {
	            query = query.Where(filterExpression);    
	        }
	
	        return query.Count();
	    }
	
	    
	    public virtual TDto GetByKey(string dtoKey)
	    {
	        ObjectKey key = KeyUtility.Instance.Convert<TEntity>(dtoKey);
			
	        return this.assembler.Assemble(this.Repository.Get(key));
	    }
	
	    public virtual string Add(TDto dto)
	    {
	        TEntity entity = this.assembler.Assemble(null, dto);
	
	        this.repository.Add(entity);
	
	        ObjectKey key = KeyUtility.Instance.Create(entity);
	
	        return KeyUtility.Instance.Convert(key);
	    }
	
	    public virtual void Update(TDto dto)
	    {
	        ObjectKey key = KeyUtility.Instance.Convert<TEntity>(dto.DtoKey);
	        TEntity entity = this.repository.Get(key);
	
	        this.assembler.Assemble(entity, dto);
	    }
	
	    public virtual void Delete(TDto dto)
	    {
			ObjectKey key = KeyUtility.Instance.Convert<TEntity>(dto.DtoKey);
	        TEntity entity = this.repository.Get(key);
	
	        this.Repository.Remove(entity);
	    }
	}
	
	public partial interface IStudioCommercialeService : IService<StudioCommercialeDto, StudioCommerciale>
	{
	
	}
	
	public partial class StudioCommercialeService : Service<StudioCommercialeDto, StudioCommerciale>, IStudioCommercialeService
	{
	    public StudioCommercialeService(IStudioCommercialeAssembler assembler, IStudioCommercialeRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IAziendaService : IService<AziendaDto, Azienda>
	{
	
	}
	
	public partial class AziendaService : Service<AziendaDto, Azienda>, IAziendaService
	{
	    public AziendaService(IAziendaAssembler assembler, IAziendaRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IContabilitaService : IService<ContabilitaDto, Contabilita>
	{
	
	}
	
	public partial class ContabilitaService : Service<ContabilitaDto, Contabilita>, IContabilitaService
	{
	    public ContabilitaService(IContabilitaAssembler assembler, IContabilitaRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IComunicazioneService : IService<ComunicazioneDto, Comunicazione>
	{
	
	}
	
	public partial class ComunicazioneService : Service<ComunicazioneDto, Comunicazione>, IComunicazioneService
	{
	    public ComunicazioneService(IComunicazioneAssembler assembler, IComunicazioneRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IDocumentoService : IService<DocumentoDto, Documento>
	{
	
	}
	
	public partial class DocumentoService : Service<DocumentoDto, Documento>, IDocumentoService
	{
	    public DocumentoService(IDocumentoAssembler assembler, IDocumentoRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IAccountService : IService<AccountDto, Account>
	{
	
	}
	
	public partial class AccountService : Service<AccountDto, Account>, IAccountService
	{
	    public AccountService(IAccountAssembler assembler, IAccountRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IImportService : IService<ImportDto, Import>
	{
	
	}
	
	public partial class ImportService : Service<ImportDto, Import>, IImportService
	{
	    public ImportService(IImportAssembler assembler, IImportRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IExportService : IService<ExportDto, Export>
	{
	
	}
	
	public partial class ExportService : Service<ExportDto, Export>, IExportService
	{
	    public ExportService(IExportAssembler assembler, IExportRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface INominativoService : IService<NominativoDto, Nominativo>
	{
	
	}
	
	public partial class NominativoService : Service<NominativoDto, Nominativo>, INominativoService
	{
	    public NominativoService(INominativoAssembler assembler, INominativoRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IClienteService : IService<ClienteDto, Cliente>
	{
	
	}
	
	public partial class ClienteService : Service<ClienteDto, Cliente>, IClienteService
	{
	    public ClienteService(IClienteAssembler assembler, IClienteRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
}
#pragma warning restore 1591