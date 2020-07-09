﻿// <copyright file="GroupExtensions.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.CompanyCommunicator.Common.Services.MicrosoftGraph.Groups
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Group Extension.
    /// </summary>
    public static class GroupExtensions
    {
        /// <summary>
        /// Check if visibility is hidden membership.
        /// </summary>
        /// <param name="visibility">The visibility.</param>
        /// <returns>Indicating if the visibility is hidden membership.</returns>
        public static bool IsHiddenMemberShip(this string visibility) =>
            !string.IsNullOrEmpty(visibility) &&
            visibility.Equals(Constants.HiddenMembership, StringComparison.CurrentCultureIgnoreCase);
    }
}
