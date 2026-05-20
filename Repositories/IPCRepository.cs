namespace APBD_TASK7.Repositories;
using APBD_TASK7.DTOs;

public interface IPCRepository
{
    Task<IEnumerable<PCDto>> GetAllPcsAsync();
    Task<PcComponentsResponse?> GetPcComponentsAsync(int id);
    Task<PCDto> CreatePcAsync(CreatePcRequest request);
    Task<bool> UpdatePcAsync(int id, UpdatePcRequest request);
    Task<bool> DeletePcAsync(int id);
}