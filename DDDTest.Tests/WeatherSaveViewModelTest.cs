using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DDDTest.Tests
{
    [TestClass]
    public class WeatherSaveViewModelTest
    {
        [TestMethod]
        public void 天気登録シナリオ()
        {
            var viewModel = new WeatherSaveViewModel();
            viewModel.SelectedAreaId.Is(null);
            viewModel.DataDateValue.Is(Convert.ToDateTime("2018/01/01 12:34:56"));

        }
    }
}
