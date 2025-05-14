namespace Module_18;

public class Downloader
{
    private ICommand? _command;

    public void SetCommand(ICommand? command)
    {
        _command = command;
    }

    public async Task ExecuteTaskAsync()
    {
        if (_command != null)
            await _command.ExecuteAsync();
    }
}
