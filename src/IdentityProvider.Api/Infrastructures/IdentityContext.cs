﻿using IdentityProvider.Api.Models;

namespace IdentityProvider.Api.Infrastructures;

public class IdentityContext
{
    public required IEnumerable<UserIdentity> Users { get; set; }
}
