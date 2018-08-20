﻿namespace iqoptionapi.ws.request {
    internal class SsidWsMessageBase : WsMessageBase<string> {
        public SsidWsMessageBase(string ssid) {
            base.Message = ssid;
        }

        public override string Name => "ssid";
    }
}