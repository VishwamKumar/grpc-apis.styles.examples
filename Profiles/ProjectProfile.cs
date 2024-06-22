


namespace ToDoApp.GrpcApi.Transcoding;

public class ProjectProfile:Profile
{
    public ProjectProfile()
    {
        CreateMap<ToDo, ToDoReply>();
    }
}
