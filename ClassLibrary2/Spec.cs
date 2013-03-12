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
}