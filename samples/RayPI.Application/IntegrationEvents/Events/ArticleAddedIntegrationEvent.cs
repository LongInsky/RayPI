﻿using System;
using System.Collections.Generic;
using System.Text;
using Ray.EventBus.Events;
using RayPI.Application.ArticleApp.Dtos;
using RayPI.Domain.Aggregates.ArticleAggregate;

namespace RayPI.Application.IntegrationEvents.Events
{
    public class ArticleAddedIntegrationEvent : IntegrationEvent
    {
        public ArticleAddedIntegrationEvent(Guid articleId)
        {
            ArticleId = articleId;
        }

        public Guid ArticleId { get; }
    }
}
