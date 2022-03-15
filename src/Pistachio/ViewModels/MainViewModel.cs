namespace Pistachio.ViewModels
{
    internal class MainViewModel : BindableBase
    {

        /// <summary>
        /// Private variables for the ViewModel
        /// </summary>
        private ObservableCollection<Note> _Notes;
        private Note _SelectedNote;

        /// <summary>
        /// Default constructor for the ViewModel which will initialize the notes etc.
        /// </summary>
        public MainViewModel()
        {
            GenerateDummyNotes();        
        }

        /// <summary>
///Function to generate dummy notes
/// This function will serve as a data provider for the notes till the time we are not working on database system.
        /// </summary>
        public void GenerateDummyNotes()
                    {
            // Create an instance of Note
            _Notes = new();
            // Now let's generate the 10 dummy notes via loop
            for(int i = 1; i <= 10; i++)
            {
                Note note = new ()
                {
                    Id = i,
                    Title = $"Note{i}",
                    Content = $"Note {i} Content"
                };
                _Notes.Add(note);
            }

        }

        public ObservableCollection<Note> Notes
        {
            get { 
                return _Notes; 
            }
set
            {
                SetProperty(ref _Notes, value);
            }
        }

        public Note SelectedNote
        {
            get {
                 return _SelectedNote; 
            }
            set
            {
SetProperty(ref _SelectedNote, value);
                             }
        }


    }
}
