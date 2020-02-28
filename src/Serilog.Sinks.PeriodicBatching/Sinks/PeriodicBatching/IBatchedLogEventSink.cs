// Copyright 2013-2020 Serilog Contributors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections.Generic;
using System.Threading.Tasks;
using Serilog.Events;

namespace Serilog.Sinks.PeriodicBatching
{
    /// <summary>
    /// Interface for targets that accept events in batches.
    /// </summary>
    public interface IBatchedLogEventSink
    {
        /// <summary>
        /// Emit a batch of log events, running asynchronously.
        /// </summary>
        /// <param name="batch">The batch of events to emit.</param>
        Task EmitBatchAsync(IEnumerable<LogEvent> batch);

        /// <summary>
        /// Allows sinks to perform periodic work without requiring additional threads
        /// or timers (thus avoiding additional flush/shut-down complexity).
        /// </summary>
        Task OnEmptyBatchAsync();
    }
}
