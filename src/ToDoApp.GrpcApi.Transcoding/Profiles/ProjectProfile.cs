
namespace ToDoApp.GrpcApi.Transcoding.Profiles;

public class ProjectProfile:Profile
{
    public ProjectProfile()
    {
        CreateMap<ToDo, ToDoReply>();
    }
}
