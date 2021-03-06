/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd
 *
 * Licensed under the Flora License, Version 1.1 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://floralicense.org/license/
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Tizen.Xamarin.Forms.Extension.Renderer;

namespace Lescanner.Tizen.Mobile
{
    class Program : global::Xamarin.Forms.Platform.Tizen.FormsApplication
    {
        App app_;
        protected override void OnCreate()
        {
            base.OnCreate();
            MainWindow.AvailableRotations = ElmSharp.DisplayRotation.Degree_0;
            app_ = new App();
            LoadApplication(app_);
        }

        protected override void OnTerminate()
        {
            app_.Terminate();
        }

        static void Main(string[] args)
        {
            var app = new Program();
            TizenFormsExtension.Init();
            global::Xamarin.Forms.Platform.Tizen.Forms.Init(app);
            app.Run(args);
        }
    }
}
