namespace APBD_TASK7.Services;
using APBD_TASK7.DTOs;
using APBD_TASK7.Repositories;

public class PcService : IPcService
{
    private readonly IPCRepository _repository;

    public PcService(IPCRepository repository)
    {
        _repository = repository;
    }

    public Task<IEnumerable<PCDto>> GetAllPcsAsync()
    {
        return _repository.GetAllPcsAsync();
    }

    public Task<PcComponentsResponse?> GetPcComponentsAsync(int id)
    {
        return _repository.GetPcComponentsAsync(id);
    }

    public Task<PCDto> CreatePcAsync(CreatePcRequest request)
    {
        return _repository.CreatePcAsync(request);
    }

    public Task<bool> UpdatePcAsync(int id, UpdatePcRequest request)
    {
        return _repository.UpdatePcAsync(id, request);
    }

    public Task<bool> DeletePcAsync(int id)
    {
        return _repository.DeletePcAsync(id);
    }
}