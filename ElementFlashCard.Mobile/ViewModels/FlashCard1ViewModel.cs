using ElementFlashCard.Mobile.Service;
using Reactive.Bindings;

namespace ElementFlashCard.Mobile.ViewModel;

public class FlashCard1ViewModel
{
    public ReactiveProperty<double> Progress { get; set; } = new ReactiveProperty<double>(0);
    private int I { get; set; } = 0;
    private List<Model.Element> Date { get; set; }
    private bool IsAnswerDisplay { get; set; } = false;
    private bool IsDisplayedElementNumber { get; set; }

    private INavigationService _navigationService;
    public FlashCard1ViewModel(ISettingService settingService,INavigationService navigationService)
    {
        _navigationService = navigationService;
        Date = new List<Model.Element>
        {
            new(1, "H", "水素"),
            new(2, "He", "ヘリウム"),
            new(3, "Li", "リチウム"),
            new(4, "Be", "ベリリウム"),
            new(5, "B", "ホウ素"),
            new(6, "C", "炭素"),
            new(7, "N", "窒素"),
            new(8, "O", "酸素"),
            new(9, "F", "フッ素"),
            new(10, "Ne", "ネオン"),
            new(11, "Na", "ナトリウム"),
            new(12, "Mg", "マグネシウム"),
            new(13, "Al", "アルミニウム"),
            new(14, "Si", "ケイ素"),
            new(15, "P", "リン"),
            new(16, "S", "硫黄"),
            new(17, "Cl", "塩素"),
            new(18, "Ar", "アルゴン"),
            new(19, "K", "カリウム"),
            new(20, "Ca", "カルシウム"),
            new(21, "Sc", "スカンジウム"),
            new(22, "Ti", "チタン"),
            new(23, "V", "バナジウム"),
            new(24, "Cr", "クロム"),
            new(25, "Mn", "マンガン"),
            new(26, "Fe", "鉄"),
            new(27, "Co", "コバルト"),
            new(28, "Ni", "ニッケル"),
            new(29, "Cu", "銅"),
            new(30, "Zn", "亜鉛"),
            new(31, "Ga", "ガリウム"),
            new(32, "Ge", "ゲルマニウム"),
            new(33, "As", "ヒ素"),
            new(34, "Se", "セレン"),
            new(35, "Br", "臭素"),
            new(36, "Kr", "クリプトン"),
            new(37, "Rb", "ルビジウム"),
            new(38, "Sr", "ストロンチウム"),
            new(39, "Y", "イットリウム"),
            new(40, "Zr", "ジルコニウム"),
            new(41, "Nb", "ニオブ"),
            new(42, "Mo", "モリブデン"),
            new(43, "Tc", "テクネチウム"),
            new(44, "Ru", "ルテニウム"),
            new(45, "Rh", "ロジウム"),
            new(46, "Pd", "パラジウム"),
            new(47, "Ag", "銀"),
            new(48, "Cd", "カドミウム"),
            new(49, "In", "インジウム"),
            new(50, "Sn", "スズ"),
            new(51, "Sb", "アンチモン"),
            new(52, "Te", "テルル"),
            new(53, "I", "ヨウ素"),
            new(54, "Xe", "キセノン"),
            new(55, "Cs", "セシウム"),
            new(56, "Ba", "バリウム"),
            new(57, "La", "ランタン"),
            new(58, "Ce", "セリウム"),
            new(59, "Pr", "プラセオジム"),
            new(60, "Nd", "ネオジム"),
            new(61, "Pm", "プロメチウム"),
            new(62, "Sm", "サマリウム"),
            new(63, "Eu", "ユウロピウム"),
            new(64, "Gd", "ガドリニウム"),
            new(65, "Tb", "テルビウム"),
            new(66, "Dy", "ジスプロシウム"),
            new(67, "Ho", "ホルミウム"),
            new(68, "Er", "エルビウム"),
            new(69, "Tm", "ツリウム"),
            new(70, "Yb", "イッテルビウム"),
            new(71, "Lu", "ルテチウム"),
            new(72, "Hf", "ハフニウム"),
            new(73, "Ta", "タンタル"),
            new(74, "W", "タングステン"),
            new(75, "Re", "レニウム"),
            new(76, "Os", "オスミウム"),
            new(77, "Ir", "イリジウム"),
            new(78, "Pt", "白金"),
            new(79, "Au", "金"),
            new(80, "Hg", "水銀"),
            new(81, "Tl", "タリウム"),
            new(82, "Pb", "鉛"),
            new(83, "Bi", "ビスマス"),
            new(84, "Po", "ポロニウム"),
            new(85, "At", "アスタチン"),
            new(86, "Rn", "ラドン"),
            new(87, "Fr", "フランシウム"),
            new(88, "Ra", "ラジウム"),
            new(89, "Ac", "アクチニウム"),
            new(90, "Th", "トリウム"),
            new(91, "Pa", "プロトアクチニウム"),
            new(92, "U", "ウラン"),
            new(93, "Np", "ネプツニウム"),
            new(94, "Pu", "プルトニウム"),
            new(95, "Am", "アメリシウム"),
            new(96, "Cm", "キュリウム"),
            new(97, "Bk", "バークリウム"),
            new(98, "Cf", "カリホルニウム"),
            new(99, "Es", "アインスタイニウム"),
            new(100, "Fm", "フェルミウム"),
            new(101, "Md", "メンデレビウム"),
            new(102, "No", "ノーベリウム"),
            new(103, "Lr", "ローレンシウム"),
            new(104, "Rf", "ラザホージウム"),
            new(105, "Db", "ドブニウム"),
            new(106, "Sg", "シーボーギウム"),
            new(107, "Bh", "ボーリウム"),
            new(108, "Hs", "ハッシウム"),
            new(109, "Mt", "マイトネリウム"),
            new(110, "Ds", "ダームスタチウム"),
            new(111, "Rg", "レントゲニウム"),
            new(112, "Cn", "コペルニシウム"),
            new(113, "Nh", "ニホニウム"),
            new(114, "Fl", "フレロビウム"),
            new(115, "Mc", "モスコビウム"),
            new(116, "Lv", "リバモリウム"),
            new(117, "Ts", "テネシン"),
            new(118, "Og", "オガネソン")
        };

        var setting = settingService.GetSetting();
        if (setting.Random)
        {
            var rnd = new Random();
            var newDate = new List<Model.Element>(118);
            for (int i = 0; i < 118; i++)
            {
                var r = rnd.Next(0, Date.Count);
                newDate.Add(Date[r]);
                Date.RemoveAt(r);
            }
            Date = newDate;
        }
        IsDisplayedElementNumber = setting.IsDisplayedElementNumber;

        ElementSymbol.Value = Date[I].Symbol;
        if (IsDisplayedElementNumber)
        {
            ElementNumber.Value = Date[I].Number;
        }
        else
        {
            ElementNumber.Value = null;
        }
        NextCommand.Subscribe(async _ => await NextAsync());
    }
    
    public async Task NextAsync()
    {
        if (IsAnswerDisplay)
        {
            I++;
            if (I<118)
            {
                Progress.Value = I/118.0;
                ElementSymbol.Value = Date[I].Symbol;
                if (IsDisplayedElementNumber)
                {
                    ElementNumber.Value = Date[I].Number;
                }
                else
                {
                    ElementNumber.Value = null;
                }
                ElementName.Value = "";
                IsAnswerDisplay = false;
            }
            else
            {
                await _navigationService.GoBackAsync();
            }
        }
        else
        {
            ElementNumber.Value = Date[I].Number;
            ElementName.Value = Date[I].Name;
            IsAnswerDisplay = true;
        }
    }
    public ReactiveCommand NextCommand { get; set; } = new ReactiveCommand();
    public ReactiveProperty<string> ElementSymbol { get; set; } = new ReactiveProperty<string>();
    public ReactiveProperty<int?> ElementNumber { get; set; } = new ReactiveProperty<int?>();
    public ReactiveProperty<string> ElementName { get; set; } = new ReactiveProperty<string>();
}
