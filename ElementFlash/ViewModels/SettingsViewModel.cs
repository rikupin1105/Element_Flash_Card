using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ElementFlash.Model;
using ElementFlash.Services;

public partial class SettingViewModel : ObservableObject
{
    private readonly SettingService _settingService;

    public SettingViewModel(SettingService settingService)
    {
        _settingService = settingService;

        // 現在設定を読み込み
        ShowAtomicNumber = _settingService.Settings.ShowAtomicNumber;
        IsRandom = _settingService.Settings.IsRandom;
    }

    // ===== 設定プロパティ =====

    // ===== 元素番号表示 =====
    [ObservableProperty]
    private bool showAtomicNumber;

    partial void OnShowAtomicNumberChanged(bool value)
    {
        _settingService.Settings.ShowAtomicNumber = value;
        _settingService.Save();
    }

    // ===== ランダム設定 =====
    [ObservableProperty]
    private bool isRandom;

    partial void OnIsRandomChanged(bool value)
    {
        _settingService.Settings.IsRandom = value;
        _settingService.Save();
    }
}