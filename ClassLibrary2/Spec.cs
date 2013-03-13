using System.Windows.Controls;

using Machine.Specifications;

namespace ClassLibrary2
{
  public class Spec
  {
    Establish context = () => { new UserControl1(); };

    Because of = () => { new UserControl1(); };

    It should_succeed =
      () => true.ShouldBeTrue();
  }

  public class StaTestExample
  {
    Establish context = () => _control = new ListBox();

    It should_not_be_null = () => _control.ShouldNotBeNull();

    protected static Control _control;
  }
}