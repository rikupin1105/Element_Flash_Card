using System;
using System.Collections.Generic;
using Reactive.Bindings;
using Element_Symbol_Flash_Card.View;
using Kamishibai.Xamarin.Forms;
using Kamishibai.Xamarin.Forms.Mvvm;

namespace Element_Symbol_Flash_Card.ViewModel
{
    internal class FlashCard2ViewModel: IPageInitializeAware<bool>
    {
        public ReactiveProperty<double> Progress { get; set; } = new ReactiveProperty<double>(0);

        private int I { get; set; } = 0;
        private List<Model.Element> Date { get; set; }
        private bool IsAnswerDisplay { get; set; } = false;
        public void OnInitialize(bool random)
        {
            if (random)
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

            ElementName.Value = Date[I].Name;
            ElementNumber.Value = Date[I].Number;
            NextCommand.Subscribe(_ => Next());
            EndCommand.Subscribe(_ => End());
        }
        public FlashCard2ViewModel()
        {
            Date = new List<Model.Element>
            {
                new Model.Element(1, "H", "水素"),
                new Model.Element(2, "He", "ヘリウム"),
                new Model.Element(3, "Li", "リチウム"),
                new Model.Element(4, "Be", "ベリリウム"),
                new Model.Element(5, "B", "ホウ素"),
                new Model.Element(6, "C", "炭素"),
                new Model.Element(7, "N", "窒素"),
                new Model.Element(8, "O", "酸素"),
                new Model.Element(9, "F", "フッ素"),
                new Model.Element(10, "Ne", "ネオン"),
                new Model.Element(11, "Na", "ナトリウム"),
                new Model.Element(12, "Mg", "マグネシウム"),
                new Model.Element(13, "Al", "アルミニウム"),
                new Model.Element(14, "Si", "ケイ素"),
                new Model.Element(15, "P", "リン"),
                new Model.Element(16, "S", "硫黄"),
                new Model.Element(17, "Cl", "塩素"),
                new Model.Element(18, "Ar", "アルゴン"),
                new Model.Element(19, "K", "カリウム"),
                new Model.Element(20, "Ca", "カルシウム"),
                new Model.Element(21, "Sc", "スカンジウム"),
                new Model.Element(22, "Ti", "チタン"),
                new Model.Element(23, "V", "バナジウム"),
                new Model.Element(24, "Cr", "クロム"),
                new Model.Element(25, "Mn", "マンガン"),
                new Model.Element(26, "Fe", "鉄"),
                new Model.Element(27, "Co", "コバルト"),
                new Model.Element(28, "Ni", "ニッケル"),
                new Model.Element(29, "Cu", "銅"),
                new Model.Element(30, "Zn", "亜鉛"),
                new Model.Element(31, "Ga", "ガリウム"),
                new Model.Element(32, "Ge", "ゲルマニウム"),
                new Model.Element(33, "As", "ヒ素"),
                new Model.Element(34, "Se", "セレン"),
                new Model.Element(35, "Br", "臭素"),
                new Model.Element(36, "Kr", "クリプトン"),
                new Model.Element(37, "Rb", "ルビジウム"),
                new Model.Element(38, "Sr", "ストロンチウム"),
                new Model.Element(39, "Y", "イットリウム"),
                new Model.Element(40, "Zr", "ジルコニウム"),
                new Model.Element(41, "Nb", "ニオブ"),
                new Model.Element(42, "Mo", "モリブデン"),
                new Model.Element(43, "Tc", "テクネチウム"),
                new Model.Element(44, "Ru", "ルテニウム"),
                new Model.Element(45, "Rh", "ロジウム"),
                new Model.Element(46, "Pd", "パラジウム"),
                new Model.Element(47, "Ag", "銀"),
                new Model.Element(48, "Cd", "カドミウム"),
                new Model.Element(49, "In", "インジウム"),
                new Model.Element(50, "Sn", "スズ"),
                new Model.Element(51, "Sb", "アンチモン"),
                new Model.Element(52, "Te", "テルル"),
                new Model.Element(53, "I", "ヨウ素"),
                new Model.Element(54, "Xe", "キセノン"),
                new Model.Element(55, "Cs", "セシウム"),
                new Model.Element(56, "Ba", "バリウム"),
                new Model.Element(57, "La", "ランタン"),
                new Model.Element(58, "Ce", "セリウム"),
                new Model.Element(59, "Pr", "プラセオジム"),
                new Model.Element(60, "Nd", "ネオジム"),
                new Model.Element(61, "Pm", "プロメチウム"),
                new Model.Element(62, "Sm", "サマリウム"),
                new Model.Element(63, "Eu", "ユウロピウム"),
                new Model.Element(64, "Gd", "ガドリニウム"),
                new Model.Element(65, "Tb", "テルビウム"),
                new Model.Element(66, "Dy", "ジスプロシウム"),
                new Model.Element(67, "Ho", "ホルミウム"),
                new Model.Element(68, "Er", "エルビウム"),
                new Model.Element(69, "Tm", "ツリウム"),
                new Model.Element(70, "Yb", "イッテルビウム"),
                new Model.Element(71, "Lu", "ルテチウム"),
                new Model.Element(72, "Hf", "ハフニウム"),
                new Model.Element(73, "Ta", "タンタル"),
                new Model.Element(74, "W", "タングステン"),
                new Model.Element(75, "Re", "レニウム"),
                new Model.Element(76, "Os", "オスミウム"),
                new Model.Element(77, "Ir", "イリジウム"),
                new Model.Element(78, "Pt", "白金"),
                new Model.Element(79, "Au", "金"),
                new Model.Element(80, "Hg", "水銀"),
                new Model.Element(81, "Tl", "タリウム"),
                new Model.Element(82, "Pb", "鉛"),
                new Model.Element(83, "Bi", "ビスマス"),
                new Model.Element(84, "Po", "ポロニウム"),
                new Model.Element(85, "At", "アスタチン"),
                new Model.Element(86, "Rn", "ラドン"),
                new Model.Element(87, "Fr", "フランシウム"),
                new Model.Element(88, "Ra", "ラジウム"),
                new Model.Element(89, "Ac", "アクチニウム"),
                new Model.Element(90, "Th", "トリウム"),
                new Model.Element(91, "Pa", "プロトアクチニウム"),
                new Model.Element(92, "U", "ウラン"),
                new Model.Element(93, "Np", "ネプツニウム"),
                new Model.Element(94, "Pu", "プルトニウム"),
                new Model.Element(95, "Am", "アメリシウム"),
                new Model.Element(96, "Cm", "キュリウム"),
                new Model.Element(97, "Bk", "バークリウム"),
                new Model.Element(98, "Cf", "カリホルニウム"),
                new Model.Element(99, "Es", "アインスタイニウム"),
                new Model.Element(100, "Fm", "フェルミウム"),
                new Model.Element(101, "Md", "メンデレビウム"),
                new Model.Element(102, "No", "ノーベリウム"),
                new Model.Element(103, "Lr", "ローレンシウム"),
                new Model.Element(104, "Rf", "ラザホージウム"),
                new Model.Element(105, "Db", "ドブニウム"),
                new Model.Element(106, "Sg", "シーボーギウム"),
                new Model.Element(107, "Bh", "ボーリウム"),
                new Model.Element(108, "Hs", "ハッシウム"),
                new Model.Element(109, "Mt", "マイトネリウム"),
                new Model.Element(110, "Ds", "ダームスタチウム"),
                new Model.Element(111, "Rg", "レントゲニウム"),
                new Model.Element(112, "Cn", "コペルニシウム"),
                new Model.Element(113, "Nh", "ニホニウム"),
                new Model.Element(114, "Fl", "フレロビウム"),
                new Model.Element(115, "Mc", "モスコビウム"),
                new Model.Element(116, "Lv", "リバモリウム"),
                new Model.Element(117, "Ts", "テネシン"),
                new Model.Element(118, "Og", "オガネソン")
            };
        }
        public void Next()
        {
            if (IsAnswerDisplay)
            {
                I++;
                if (I<118)
                {
                    Progress.Value = I/118.0;
                    ElementName.Value = Date[I].Name;
                    ElementNumber.Value = Date[I].Number;
                    ElementSymbol.Value = "";
                    IsAnswerDisplay = false;
                }
                else
                {
                    End();
                }
            }
            else
            {
                ElementSymbol.Value = Date[I].Symbol;
                IsAnswerDisplay = true;
            }
        }
        public async void End()
        {
            await RequestBack.RaiseAsync();
        }
        public INavigationRequest RequestBack { get; } = new NavigationRequest();
        public ReactiveCommand EndCommand { get; set; } = new ReactiveCommand();
        public ReactiveCommand NextCommand { get; set; } = new ReactiveCommand();
        public ReactiveProperty<string> ElementSymbol { get; set; } = new ReactiveProperty<string>();
        public ReactiveProperty<int> ElementNumber { get; set; } = new ReactiveProperty<int>();
        public ReactiveProperty<string> ElementName { get; set; } = new ReactiveProperty<string>();
    }
}
