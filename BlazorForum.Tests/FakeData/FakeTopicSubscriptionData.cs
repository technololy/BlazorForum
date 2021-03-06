﻿using BlazorForum.Models;
using System.Collections.Generic;

namespace BlazorForum.Tests.FakeData
{
    public class FakeTopicSubscriptionData
    {
        public static TopicSubscription GetTopicSubscription(string userId, int forumTopicId)
        {
            return new TopicSubscription()
            {
                TopicSubscriptionsId = 1,
                Id = userId,
                ForumTopicId = forumTopicId
            };
        }

        public static List<TopicSubscription> GetTopicSubscriptions(string userId, int forumTopicId)
        {
            var topicSubscriptions = new List<TopicSubscription>();
            topicSubscriptions.Add(GetTopicSubscription(userId, forumTopicId));
            return topicSubscriptions;
        }
    }
}
