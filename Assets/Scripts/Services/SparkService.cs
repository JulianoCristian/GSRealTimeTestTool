using System;
using GameSparks.Api.Responses;

namespace Services
{
    public static class SparkService
    {
        public static void MatchmakingRequest(int skill, string shortCode, Action<MatchmakingResponse> onMatchMakingResponse)
        {
            new GameSparks.Api.Requests.MatchmakingRequest()
                .SetSkill(skill)    
                .SetMatchShortCode(shortCode)
                .Send(onMatchMakingResponse);
        }
    }
}