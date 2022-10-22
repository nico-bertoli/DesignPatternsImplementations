using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal interface IBuilder
{
    public void BuildHead();
    public void BuildBody();
    public void BuildArms();
    public void BuildLegs();
}