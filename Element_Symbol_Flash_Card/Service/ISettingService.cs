using Element_Symbol_Flash_Card.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Element_Symbol_Flash_Card.Service
{
    public interface ISettingService
    {
        void Save(Setting setting);
        Setting GetSetting();
    }
}
