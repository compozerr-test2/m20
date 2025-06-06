import React from "react"
import { createFileRoute } from '@tanstack/react-router'
import M20Component from '../../m20-component'

export const Route = createFileRoute('/m20/')({
  component: RouteComponent,
})

function RouteComponent() {
  return (
    <div>
      <M20Component name="World!" />
    </div>
  )
}
