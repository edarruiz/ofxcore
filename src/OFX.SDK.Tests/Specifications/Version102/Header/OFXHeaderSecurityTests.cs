﻿using OFX.SDK.Reflection;
using OFX.SDK.Specifications.Version102;
using Xunit;

namespace OFX.SDK.Tests.Specifications.Version102.Header;

#region BSD-3 Copyright Information
/*
  Copyright (c) 2022, Eric Roberto Darruiz
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without
  modification, are permitted provided that the following conditions are met:
  
  1. Redistributions of source code must retain the above copyright notice, this
     list of conditions and the following disclaimer.
  
  2. Redistributions in binary form must reproduce the above copyright notice,
     this list of conditions and the following disclaimer in the documentation
     and/or other materials provided with the distribution.
  
  3. Neither the name of the copyright holder nor the names of its
     contributors may be used to endorse or promote products derived from
     this software without specific prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
  AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
  IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
  DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
  FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
  DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
  SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
  CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
  OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
  OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/
#endregion

public class OFXHeaderSecurityTests {
    #region Tests
    [Fact(DisplayName = "OFXHeaderSecurity.None OFXValueAttribute")]
    [Trait("OFXHeaderSecurity", "None")]
    public void GetNoneOFXValueAttribute() {
        // Arrange
        var actual = OFXHeaderSecurity.None;
        var expected = "NONE";

        // Act
        var result = actual.GetOFXValueAttribute();

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact(DisplayName = "OFXHeaderSecurity.Type1 OFXValueAttribute")]
    [Trait("OFXHeaderSecurity", "Type1")]
    public void GetType1OFXValueAttribute() {
        // Arrange
        var actual = OFXHeaderSecurity.Type1;
        var expected = "TYPE1";

        // Act
        var result = actual.GetOFXValueAttribute();

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion
}