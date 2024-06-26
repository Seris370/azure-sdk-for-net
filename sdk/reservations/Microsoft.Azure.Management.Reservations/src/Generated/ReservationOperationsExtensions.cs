// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ReservationOperations.
    /// </summary>
    public static partial class ReservationOperationsExtensions
    {
            /// <summary>
            /// Get Available Scopes for `Reservation`.
            /// </summary>
            /// <remarks>
            /// Get Available Scopes for `Reservation`.
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='reservationId'>
            /// Id of the Reservation Item
            /// </param>
            /// <param name='body'>
            /// </param>
            public static AvailableScopeProperties AvailableScopes(this IReservationOperations operations, string reservationOrderId, string reservationId, AvailableScopeRequest body)
            {
                return operations.AvailableScopesAsync(reservationOrderId, reservationId, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get Available Scopes for `Reservation`.
            /// </summary>
            /// <remarks>
            /// Get Available Scopes for `Reservation`.
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='reservationId'>
            /// Id of the Reservation Item
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AvailableScopeProperties> AvailableScopesAsync(this IReservationOperations operations, string reservationOrderId, string reservationId, AvailableScopeRequest body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AvailableScopesWithHttpMessagesAsync(reservationOrderId, reservationId, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Split the `Reservation`.
            /// </summary>
            /// <remarks>
            /// Split a `Reservation` into two `Reservation`s with specified quantity
            /// distribution.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='body'>
            /// Information needed to Split a reservation item
            /// </param>
            public static IList<ReservationResponse> Split(this IReservationOperations operations, string reservationOrderId, SplitRequest body)
            {
                return operations.SplitAsync(reservationOrderId, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Split the `Reservation`.
            /// </summary>
            /// <remarks>
            /// Split a `Reservation` into two `Reservation`s with specified quantity
            /// distribution.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='body'>
            /// Information needed to Split a reservation item
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ReservationResponse>> SplitAsync(this IReservationOperations operations, string reservationOrderId, SplitRequest body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SplitWithHttpMessagesAsync(reservationOrderId, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Merges two `Reservation`s.
            /// </summary>
            /// <remarks>
            /// Merge the specified `Reservation`s into a new `Reservation`. The two
            /// `Reservation`s being merged must have same properties.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='body'>
            /// Information needed for commercial request for a reservation
            /// </param>
            public static IList<ReservationResponse> Merge(this IReservationOperations operations, string reservationOrderId, MergeRequest body)
            {
                return operations.MergeAsync(reservationOrderId, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Merges two `Reservation`s.
            /// </summary>
            /// <remarks>
            /// Merge the specified `Reservation`s into a new `Reservation`. The two
            /// `Reservation`s being merged must have same properties.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='body'>
            /// Information needed for commercial request for a reservation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ReservationResponse>> MergeAsync(this IReservationOperations operations, string reservationOrderId, MergeRequest body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.MergeWithHttpMessagesAsync(reservationOrderId, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get `Reservation`s in a given reservation Order
            /// </summary>
            /// <remarks>
            /// List `Reservation`s within a single `ReservationOrder`.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            public static IPage<ReservationResponse> List(this IReservationOperations operations, string reservationOrderId)
            {
                return operations.ListAsync(reservationOrderId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get `Reservation`s in a given reservation Order
            /// </summary>
            /// <remarks>
            /// List `Reservation`s within a single `ReservationOrder`.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ReservationResponse>> ListAsync(this IReservationOperations operations, string reservationOrderId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(reservationOrderId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get `Reservation` details.
            /// </summary>
            /// <remarks>
            /// Get specific `Reservation` details.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationId'>
            /// Id of the Reservation Item
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='expand'>
            /// Supported value of this query is renewProperties
            /// </param>
            public static ReservationResponse Get(this IReservationOperations operations, string reservationId, string reservationOrderId, string expand = default(string))
            {
                return operations.GetAsync(reservationId, reservationOrderId, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get `Reservation` details.
            /// </summary>
            /// <remarks>
            /// Get specific `Reservation` details.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationId'>
            /// Id of the Reservation Item
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='expand'>
            /// Supported value of this query is renewProperties
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ReservationResponse> GetAsync(this IReservationOperations operations, string reservationId, string reservationOrderId, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(reservationId, reservationOrderId, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a `Reservation`.
            /// </summary>
            /// <remarks>
            /// Updates the applied scopes of the `Reservation`.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='reservationId'>
            /// Id of the Reservation Item
            /// </param>
            /// <param name='parameters'>
            /// Information needed to patch a reservation item
            /// </param>
            public static ReservationResponse Update(this IReservationOperations operations, string reservationOrderId, string reservationId, Patch parameters)
            {
                return operations.UpdateAsync(reservationOrderId, reservationId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a `Reservation`.
            /// </summary>
            /// <remarks>
            /// Updates the applied scopes of the `Reservation`.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='reservationId'>
            /// Id of the Reservation Item
            /// </param>
            /// <param name='parameters'>
            /// Information needed to patch a reservation item
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ReservationResponse> UpdateAsync(this IReservationOperations operations, string reservationOrderId, string reservationId, Patch parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(reservationOrderId, reservationId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get `Reservation` revisions.
            /// </summary>
            /// <remarks>
            /// List of all the revisions for the `Reservation`.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationId'>
            /// Id of the Reservation Item
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            public static IPage<ReservationResponse> ListRevisions(this IReservationOperations operations, string reservationId, string reservationOrderId)
            {
                return operations.ListRevisionsAsync(reservationId, reservationOrderId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get `Reservation` revisions.
            /// </summary>
            /// <remarks>
            /// List of all the revisions for the `Reservation`.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationId'>
            /// Id of the Reservation Item
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ReservationResponse>> ListRevisionsAsync(this IReservationOperations operations, string reservationId, string reservationOrderId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListRevisionsWithHttpMessagesAsync(reservationId, reservationOrderId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List the reservations and the roll up counts of reservations group by
            /// provisioning states that the user has access to in the current tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='filter'>
            /// May be used to filter by reservation properties. The filter supports 'eq',
            /// 'or', and 'and'. It does not currently support 'ne', 'gt', 'le', 'ge', or
            /// 'not'. Reservation properties include sku/name,
            /// properties/{appliedScopeType, archived, displayName,
            /// displayProvisioningState, effectiveDateTime, expiryDate, provisioningState,
            /// quantity, renew, reservedResourceType, term, userFriendlyAppliedScopeType,
            /// userFriendlyRenewState}
            /// </param>
            /// <param name='orderby'>
            /// May be used to sort order by reservation properties.
            /// </param>
            /// <param name='refreshSummary'>
            /// To indicate whether to refresh the roll up counts of the reservations group
            /// by provisioning states
            /// </param>
            /// <param name='skiptoken'>
            /// The number of reservations to skip from the list before returning results
            /// </param>
            /// <param name='selectedState'>
            /// The selected provisioning state
            /// </param>
            /// <param name='take'>
            /// To number of reservations to return
            /// </param>
            public static IPage<ReservationResponse> ListAll(this IReservationOperations operations, string filter = default(string), string orderby = default(string), string refreshSummary = default(string), double? skiptoken = default(double?), string selectedState = default(string), double? take = default(double?))
            {
                return operations.ListAllAsync(filter, orderby, refreshSummary, skiptoken, selectedState, take).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the reservations and the roll up counts of reservations group by
            /// provisioning states that the user has access to in the current tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='filter'>
            /// May be used to filter by reservation properties. The filter supports 'eq',
            /// 'or', and 'and'. It does not currently support 'ne', 'gt', 'le', 'ge', or
            /// 'not'. Reservation properties include sku/name,
            /// properties/{appliedScopeType, archived, displayName,
            /// displayProvisioningState, effectiveDateTime, expiryDate, provisioningState,
            /// quantity, renew, reservedResourceType, term, userFriendlyAppliedScopeType,
            /// userFriendlyRenewState}
            /// </param>
            /// <param name='orderby'>
            /// May be used to sort order by reservation properties.
            /// </param>
            /// <param name='refreshSummary'>
            /// To indicate whether to refresh the roll up counts of the reservations group
            /// by provisioning states
            /// </param>
            /// <param name='skiptoken'>
            /// The number of reservations to skip from the list before returning results
            /// </param>
            /// <param name='selectedState'>
            /// The selected provisioning state
            /// </param>
            /// <param name='take'>
            /// To number of reservations to return
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ReservationResponse>> ListAllAsync(this IReservationOperations operations, string filter = default(string), string orderby = default(string), string refreshSummary = default(string), double? skiptoken = default(double?), string selectedState = default(string), double? take = default(double?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(filter, orderby, refreshSummary, skiptoken, selectedState, take, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get Available Scopes for `Reservation`.
            /// </summary>
            /// <remarks>
            /// Get Available Scopes for `Reservation`.
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='reservationId'>
            /// Id of the Reservation Item
            /// </param>
            /// <param name='body'>
            /// </param>
            public static AvailableScopeProperties BeginAvailableScopes(this IReservationOperations operations, string reservationOrderId, string reservationId, AvailableScopeRequest body)
            {
                return operations.BeginAvailableScopesAsync(reservationOrderId, reservationId, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get Available Scopes for `Reservation`.
            /// </summary>
            /// <remarks>
            /// Get Available Scopes for `Reservation`.
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='reservationId'>
            /// Id of the Reservation Item
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AvailableScopeProperties> BeginAvailableScopesAsync(this IReservationOperations operations, string reservationOrderId, string reservationId, AvailableScopeRequest body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginAvailableScopesWithHttpMessagesAsync(reservationOrderId, reservationId, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Split the `Reservation`.
            /// </summary>
            /// <remarks>
            /// Split a `Reservation` into two `Reservation`s with specified quantity
            /// distribution.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='body'>
            /// Information needed to Split a reservation item
            /// </param>
            public static IList<ReservationResponse> BeginSplit(this IReservationOperations operations, string reservationOrderId, SplitRequest body)
            {
                return operations.BeginSplitAsync(reservationOrderId, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Split the `Reservation`.
            /// </summary>
            /// <remarks>
            /// Split a `Reservation` into two `Reservation`s with specified quantity
            /// distribution.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='body'>
            /// Information needed to Split a reservation item
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ReservationResponse>> BeginSplitAsync(this IReservationOperations operations, string reservationOrderId, SplitRequest body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginSplitWithHttpMessagesAsync(reservationOrderId, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Merges two `Reservation`s.
            /// </summary>
            /// <remarks>
            /// Merge the specified `Reservation`s into a new `Reservation`. The two
            /// `Reservation`s being merged must have same properties.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='body'>
            /// Information needed for commercial request for a reservation
            /// </param>
            public static IList<ReservationResponse> BeginMerge(this IReservationOperations operations, string reservationOrderId, MergeRequest body)
            {
                return operations.BeginMergeAsync(reservationOrderId, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Merges two `Reservation`s.
            /// </summary>
            /// <remarks>
            /// Merge the specified `Reservation`s into a new `Reservation`. The two
            /// `Reservation`s being merged must have same properties.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='body'>
            /// Information needed for commercial request for a reservation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ReservationResponse>> BeginMergeAsync(this IReservationOperations operations, string reservationOrderId, MergeRequest body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginMergeWithHttpMessagesAsync(reservationOrderId, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a `Reservation`.
            /// </summary>
            /// <remarks>
            /// Updates the applied scopes of the `Reservation`.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='reservationId'>
            /// Id of the Reservation Item
            /// </param>
            /// <param name='parameters'>
            /// Information needed to patch a reservation item
            /// </param>
            public static ReservationResponse BeginUpdate(this IReservationOperations operations, string reservationOrderId, string reservationId, Patch parameters)
            {
                return operations.BeginUpdateAsync(reservationOrderId, reservationId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a `Reservation`.
            /// </summary>
            /// <remarks>
            /// Updates the applied scopes of the `Reservation`.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='reservationId'>
            /// Id of the Reservation Item
            /// </param>
            /// <param name='parameters'>
            /// Information needed to patch a reservation item
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ReservationResponse> BeginUpdateAsync(this IReservationOperations operations, string reservationOrderId, string reservationId, Patch parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(reservationOrderId, reservationId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get `Reservation`s in a given reservation Order
            /// </summary>
            /// <remarks>
            /// List `Reservation`s within a single `ReservationOrder`.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ReservationResponse> ListNext(this IReservationOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get `Reservation`s in a given reservation Order
            /// </summary>
            /// <remarks>
            /// List `Reservation`s within a single `ReservationOrder`.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ReservationResponse>> ListNextAsync(this IReservationOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get `Reservation` revisions.
            /// </summary>
            /// <remarks>
            /// List of all the revisions for the `Reservation`.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ReservationResponse> ListRevisionsNext(this IReservationOperations operations, string nextPageLink)
            {
                return operations.ListRevisionsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get `Reservation` revisions.
            /// </summary>
            /// <remarks>
            /// List of all the revisions for the `Reservation`.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ReservationResponse>> ListRevisionsNextAsync(this IReservationOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListRevisionsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List the reservations and the roll up counts of reservations group by
            /// provisioning states that the user has access to in the current tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ReservationResponse> ListAllNext(this IReservationOperations operations, string nextPageLink)
            {
                return operations.ListAllNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the reservations and the roll up counts of reservations group by
            /// provisioning states that the user has access to in the current tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ReservationResponse>> ListAllNextAsync(this IReservationOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
