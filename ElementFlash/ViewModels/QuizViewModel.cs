using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ElementFlash.Services;

namespace ElementFlash.ViewModels;

[QueryProperty(nameof(Mode), "Mode")]
public partial class QuizViewModel : ObservableObject
{
    private readonly ElementService _elementService;

    public QuizViewModel(ElementService elementService, SettingService settingService)
    {
        _elementService = elementService;
        MaxAtomicNumber = elementService.GetAll().Count;

        //1から118の配列を作成
        numbers = Enumerable.Range(0, MaxAtomicNumber-1).ToArray();
        if (settingService.Settings.IsRandom)
        {
            Random rand = new Random();

            for (int i = numbers.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                (numbers[i], numbers[j]) = (numbers[j], numbers[i]);
            }
        }
    }
    private readonly int[] numbers;

    partial void OnModeChanged(string value)
    {
        Mode = value;
        LoadNext();
    }

    [ObservableProperty]
    private string mode = "";

    [ObservableProperty]
    private bool isFinished = false;

    [ObservableProperty]
    private Model.Element? currentElement;

    [ObservableProperty]
    private string mainText = "";

    [ObservableProperty]
    private string atomicNumberText = "";

    [ObservableProperty]
    private bool isAnswerVisible = false;

    private int currentNumber = 1;
    private int MaxAtomicNumber = 118;

    [RelayCommand]
    private void CardTapped()
    {
        if (IsFinished)
        {
            return;
        }
        ;
        if (CurrentElement == null)
            return;

        if (!IsAnswerVisible)
        {
            MainText = Mode == "SymbolToElement"
                ? CurrentElement.Name
                : CurrentElement.Symbol;

            IsAnswerVisible = true;
        }
        else
        {
            currentNumber++;
            if (currentNumber >= MaxAtomicNumber)
            {
                IsFinished = true;
                return;
            }
            LoadNext();
        }
    }

    private void LoadNext()
    {
        CurrentElement = _elementService.Get(numbers[currentNumber-1]);
        IsAnswerVisible = false;

        MainText = Mode == "SymbolToElement"
            ? CurrentElement.Symbol
            : CurrentElement.Name;

        AtomicNumberText = CurrentElement.AtomicNumber.ToString();
    }
}