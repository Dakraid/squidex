﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschraenkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using Squidex.Domain.Apps.Core.Apps;
using Squidex.Domain.Apps.Core.TestHelpers;
using Xunit;

namespace Squidex.Domain.Apps.Core.Model.Apps
{
    public class AppImageTests
    {
        [Fact]
        public void Should_create_app_image()
        {
            var imageEtag = "etag";
            var imageMime = "image/png";

            var appImage = new AppImage(imageMime, imageEtag);

            Assert.Equal(imageEtag, appImage.Etag);
            Assert.Equal(imageMime, appImage.MimeType);
        }

        [Fact]
        public void Should_create_app_image_with_autogenerated_etag()
        {
            var appImage = new AppImage("image/png");

            Assert.True(appImage.Etag.Length > 10);
        }

        [Fact]
        public void Should_serialize_and_deserialize()
        {
            var appImage = new AppImage("image/png");

            var serialized = appImage.SerializeAndDeserialize();

            Assert.Equal(appImage, serialized);
        }
    }
}
