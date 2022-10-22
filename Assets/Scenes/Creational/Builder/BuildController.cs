using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildController : Singleton<BuildController>
{
    Builder builder;

    public void RegisterBuilder(Builder _builder) {
        builder = _builder;
    }

    public void BuildHead() { builder.BuildHead(); }
    public void BuildBody() { builder.BuildBody(); }
    public void BuildArms() { builder.BuildArms(); }
    public void BuildLegs() { builder.BuildLegs(); }

    public void BuildDoll() {
        BuildHead();
        BuildBody();
        BuildArms();
        BuildLegs();
    }

}
